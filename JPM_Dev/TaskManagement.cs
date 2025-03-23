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
    public partial class TaskManagement : Form
    {
        public TaskManagement()
        {
            InitializeComponent();
            this.FormClosed += TaskManagement_FormClosed; 
        }

        private void TaskManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TaskManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
