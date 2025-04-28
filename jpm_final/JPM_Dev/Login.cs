using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace JPM_Dev
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.AcceptButton = loginBtn;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = userTxtBox.Text.Trim();
            string password = passwordTxtBox.Text;

            // Static Admin Credentials
            string adminEmail = "admin";
            string adminPassword = "password123";

            // Check if login is for Admin
            if (email.Equals(adminEmail, StringComparison.OrdinalIgnoreCase) && password == adminPassword)
            {
                MessageBox.Show("Login successful! Welcome Admin.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Admin adminForm = new Admin();
                adminForm.Show();
                this.Hide();
                return;
            }

            // If not Admin, check database
            string connectionString = "Data Source=WHELLMIE\\MSSQLSERVER01;Initial Catalog=JPM_Database;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT Role FROM UserProfiles WHERE Email = @Email AND Password = @Password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);

                        var roleObj = command.ExecuteScalar();

                        if (roleObj != null)
                        {
                            string role = roleObj.ToString();

                            MessageBox.Show($"Login successful! Welcome {role}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Form dashboardForm = null;

                            switch (role)
                            {
                                case "Editor":
                                    dashboardForm = new TaskForm();
                                    break;
                                case "Collaborator":
                                    dashboardForm = new Collaborator();
                                    break;
                                default:
                                    MessageBox.Show("Unknown role!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                            }

                            dashboardForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
