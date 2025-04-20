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
    public partial class Editor : Form
    {



        public Editor()
        {
            InitializeComponent();
            this.Load += new EventHandler(Editor_Load);
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            string task = Microsoft.VisualBasic.Interaction.InputBox("Enter your task:", "New Task", "");
            if (!string.IsNullOrWhiteSpace(task))
            {
                // Create task panel
                Panel taskPanel = new Panel();
                taskPanel.Size = new Size(280, 40);
                taskPanel.BackColor = Color.WhiteSmoke;
                taskPanel.Padding = new Padding(5);
                taskPanel.Margin = new Padding(5);
                taskPanel.BorderStyle = BorderStyle.FixedSingle;

                // Task label
                Label taskLabel = new Label();
                taskLabel.Text = task;
                taskLabel.Location = new Point(5, 10);
                taskLabel.AutoSize = true;

                // Done checkbox
                CheckBox doneCheck = new CheckBox();
                doneCheck.Location = new Point(150, 10);
                doneCheck.CheckedChanged += (s, args) =>
                {
                    taskLabel.Font = doneCheck.Checked
                        ? new Font(taskLabel.Font, FontStyle.Strikeout)
                        : new Font(taskLabel.Font, FontStyle.Regular);
                };

                // Delete button
                Button deleteBtn = new Button();
                deleteBtn.Text = "X";
                deleteBtn.Size = new Size(30, 25);
                deleteBtn.Location = new Point(240, 7);
                deleteBtn.Click += (s, args) =>
                {
                    taskListPanel.Controls.Remove(taskPanel);
                };

                // Add elements to panel
                taskPanel.Controls.Add(taskLabel);
                taskPanel.Controls.Add(doneCheck);
                taskPanel.Controls.Add(deleteBtn);

                // Add panel to FlowLayoutPanel
                taskListPanel.Controls.Add(taskPanel);
            }
        }

    }
}
