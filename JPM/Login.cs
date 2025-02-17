using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPM
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
                // You can navigate to another form or perform other actions here
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
