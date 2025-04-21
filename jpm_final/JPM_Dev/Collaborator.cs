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
    public partial class Collaborator : Form
    {



        public Collaborator()
        {
            InitializeComponent();
            this.Load += new EventHandler(Collaborator_Load);
        }

        private void Collaborator_Load(object sender, EventArgs e)
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
                taskPanel.Margin = new Padding(5);
                taskPanel.BorderStyle = BorderStyle.FixedSingle;

                // Task label
                Label taskLabel = new Label();
                taskLabel.Text = task;
                taskLabel.Location = new Point(5, 12);
                taskLabel.AutoSize = true;
                taskLabel.MaximumSize = new Size(180, 0); // Prevent it from overflowing

                // Done checkbox
                CheckBox doneCheck = new CheckBox();
                doneCheck.Location = new Point(190, 10);
                doneCheck.Size = new Size(20, 20); // <- control the actual size!
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
                deleteBtn.Location = new Point(230, 7);
                deleteBtn.BackColor = Color.IndianRed;
                deleteBtn.ForeColor = Color.White;
                deleteBtn.FlatStyle = FlatStyle.Flat;
                deleteBtn.FlatAppearance.BorderSize = 0;
                deleteBtn.Click += (s, args) =>
                {
                    taskListPanel.Controls.Remove(taskPanel);
                };

                // Add controls to the panel
                taskPanel.Controls.Add(taskLabel);
                taskPanel.Controls.Add(doneCheck);
                taskPanel.Controls.Add(deleteBtn);

                // Add to main list
                taskListPanel.Controls.Add(taskPanel);
            }
        }

    }
}
