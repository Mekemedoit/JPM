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
            this.FormClosed += Admin_FormClosed;
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void profile_Click(object sender, EventArgs e) //would go straight to ProfileManagement
        {
            // Create an instance of the ProfileManagement form
            ProfileManagement profileForm = new ProfileManagement();

            // Show the ProfileManagement form
            profileForm.Show();

            // Hide the current Admin form (optional)
            this.Hide();
        }

        private void task_Click(object sender, EventArgs e) // would go straight to TaskManagement
        {
            // Create an instance of the TaskManagement form
            TaskManagement taskForm = new TaskManagement();

            // Show the TaskManagement form
            taskForm.Show();

            // Hide the current Admin form (optional)
            this.Hide();
        }
    }
}
