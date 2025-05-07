using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            this.Size = new System.Drawing.Size(Convert.ToInt32(0.5 * workingRectangle.Width), Convert.ToInt32(0.5 * workingRectangle.Height));
            this.Location = new System.Drawing.Point(10, 10);


            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(panel2.Right + 10, panel1.Bottom + 10); // adjust as needed
            panel2.Size = new Size(this.ClientSize.Width - panel2.Left - 10, this.ClientSize.Height - panel2.Top - 10);


        }

        private void Admin_Resize(object sender, EventArgs e)
        {
            panel2.Size = new Size(this.ClientSize.Width - panel2.Left - 10, this.ClientSize.Height - panel2.Top - 10);
        }

        private void LoadFormInPanel(Form form)
        {
            panel2.Controls.Clear(); // Clear existing controls
            form.TopLevel = false; // Allow embedding in panel
            form.FormBorderStyle = FormBorderStyle.None; // Remove title bar
            form.Dock = DockStyle.Fill; // Make the form fill the panel
            panel2.Controls.Add(form); // Add form to panel
            form.Show(); // Display the form
        }

        // Button Click Events
        private void profile_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new ProfileManagement());
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

        private void addProjectToolStripMenuItem_Click(object sender, EventArgs e) //this one here <----
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void notification_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
