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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void profile_Click(object sender, EventArgs e)
        {
            ProfileManagement profileForm = new ProfileManagement();
            profileForm.Show();
            this.Hide();
        }

        private void task_Click(object sender, EventArgs e)
        {
            TaskManagement taskForm = new TaskManagement();
            taskForm.Show();
            this.Hide();
        }

        private void project_Click(object sender, EventArgs e)
        {
            ProjectManagement projectForm = new ProjectManagement();
            projectForm.Show();
            this.Hide();
        }

        private void report_Click(object sender, EventArgs e)
        {
            ReportMonitoring reportForm = new ReportMonitoring();
            reportForm.Show();
            this.Hide();
        }
    }
}
