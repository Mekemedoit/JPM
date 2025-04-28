using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace JPM_Dev
{
    public partial class ProfileManagement : Form
    {
        public ProfileManagement()
        {
            InitializeComponent();
        }

        private void ProfileManagement_Load(object sender, EventArgs e) { }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Collect input from text fields
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string role = cmbRole.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPass.Text.Trim();
            byte[] photo = null;

            // Validate required fields
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(role) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hash the password for security
            string hashedPassword = HashPassword(password);

            // Convert image to byte array (if a photo is attached)
            if (picProfile.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    picProfile.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    photo = ms.ToArray();
                }
            }

            // Database connection string (Modify with actual details)
            string connectionString = "Data Source=WHELLMIE\\MSSQLSERVER01;Initial Catalog=JPM_Database;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Connected Successfully");
                    string query = "INSERT INTO UserProfiles (FirstName, LastName, Role, Email, Password, ProfilePhoto) " +
                                   "VALUES (@FirstName, @LastName, @Role, @Email, @Password, @ProfilePhoto)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Role", role);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@ProfilePhoto", (object)photo ?? DBNull.Value);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Profile saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to save profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Function to hash password using SHA256
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        // Function to attach a photo
        private void btnAttachPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picProfile.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        
    }
}
