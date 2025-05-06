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
    public partial class Admin : Form
    {

        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
        public void LoadFormInPanel(Form childForm)
        {
            panelMain.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.Show();
        }

        // Button Click Events
        private void profile_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new ProfileManagement(this));
        }

        private void task_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new TaskManagement());
        }

        private void project_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new ProjectManagement());
        }

        private void report_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new ReportMonitoring());
        }


        private void user_Click(object sender, EventArgs e)
        {
            // Show the context menu at the location of the button
            contextMenuStrip1.Show(Cursor.Position);
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide(); // Hide current form
                Login loginForm = new Login(); // Replace with actual login form
                loginForm.Show();
            }
        }

        private void chat_Click(object sender, EventArgs e)
        {
            ChatForm chat = new ChatForm();
            chat.Show();
        }
    }
}
