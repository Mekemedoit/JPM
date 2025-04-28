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

        private Admin admin;
        public TaskManagement()
        {
            InitializeComponent();
  
        }


        private void TaskManagement_Load(object sender, EventArgs e)
        {

        }

        
        private void addTask_Click(object sender, EventArgs e)
        {
            admin.LoadFormInPanel(new AddTask());
        }
    }
}
