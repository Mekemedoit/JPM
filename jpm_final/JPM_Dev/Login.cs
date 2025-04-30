using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            loginPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = userTxtBox.Text;
            string password = passwordTxtBox.Text;

            if (username == "admin" && password == "password123")
            {
                MessageBox.Show("Welcome Admin!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Admin adminForm = new Admin();
                adminForm.Show();
                this.Hide();
            }
            else if (username == "editor" && password == "editorpass")
            {
                MessageBox.Show("Welcome Editor!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Editor editorForm = new Editor();
                editorForm.Show();
                this.Hide();
            }
            else if (username == "collab" && password == "collabpass")
            {
                MessageBox.Show("Welcome Collaborator!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Collaborator collabForm = new Collaborator();
                collabForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
