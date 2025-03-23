using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace JPM_Dev
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            // Attach KeyDown event handlers
            userTxtBox.KeyDown += TextBox_KeyDown;
            passwordTxtBox.KeyDown += TextBox_KeyDown;
        }

        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            PerformLogin();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformLogin();
                e.SuppressKeyPress = true; // Prevents the annoying "ding" sound
            }
        }

        private void PerformLogin()
        {
            string username = userTxtBox.Text.Trim();
            string password = passwordTxtBox.Text.Trim();

            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Admin adminForm = new Admin();
                adminForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            string connString = ConfigurationManager.ConnectionStrings["JPM_DevDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT PasswordHash FROM Users WHERE Username = @Username";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string storedPassword = result.ToString();
                        return password == storedPassword; // Direct comparison, no hashing
                    }
                }
            }
            return false;
        }


        private bool VerifyPassword(string inputPassword, string storedHash)
        {
            string hashedInput = HashPassword(inputPassword);
            return hashedInput == storedHash;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hashBytes);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private bool TestDatabaseConnection()
        {
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["JPM_DevDB"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
