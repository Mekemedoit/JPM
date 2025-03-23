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
    public partial class ProfileManagement : Form
    {
        public ProfileManagement()
        {
            InitializeComponent();
        }

        private void ProfileManagement_Load(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void textBox3_TextChanged(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void create_Click(object sender, EventArgs e)
        {

        }
        private void back_Click(object sender, EventArgs e)
        {
            Admin adminForm = new Admin();
            adminForm.Show(); 
            this.Close(); 
        }
    }
}
