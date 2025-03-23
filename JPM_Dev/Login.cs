using System;
using System.Windows.Forms;

namespace JPM_Dev
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            // Hardcoded username and password for demonstration purposes
            string validUsername = "admin";
            string validPassword = "password123";

            // Get the input from the textboxes
            string username = userTxtBox.Text;
            string password = passwordTxtBox.Text;

            // Validate the credentials
            if (username == validUsername && password == validPassword)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Create an instance of the Admin form
                Admin adminForm = new Admin();

                // Show the Admin form
                adminForm.Show();

                // Hide the Login form
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
