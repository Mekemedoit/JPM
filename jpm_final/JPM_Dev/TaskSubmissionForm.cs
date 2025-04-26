using System;
using System.Windows.Forms;

namespace JPM_Dev
{
    public partial class TaskSubmissionForm : Form
    {
        private Label taskLabel;
        private TextBox taskTextBox;
        private Button saveButton;
        private string taskId;
        private bool isEditorMode;

        public string UpdatedTask { get; private set; } // To return updated text

        public TaskSubmissionForm(string taskId, bool isEditorMode)
        {
            
            this.taskId = taskId;
            this.isEditorMode = isEditorMode;

            BuildUI();
        }

        private void BuildUI()
        {
            this.Text = isEditorMode ? "Edit Task" : "New Task";
            this.Size = new System.Drawing.Size(300, 200);
            this.StartPosition = FormStartPosition.CenterParent;

            taskLabel = new Label
            {
                Text = isEditorMode ? "Edit the task:" : "Enter your task:",
                Location = new System.Drawing.Point(10, 20),
                AutoSize = true
            };
            taskTextBox = new TextBox
            {
                Location = new System.Drawing.Point(10, 50),
                Width = 250
            };
            // Save button
            Button saveButton = new Button();
            saveButton.Text = "Save";
            saveButton.Size = new Size(80, 30);
            saveButton.Location = new Point(90, 120);
            saveButton.Click += (s, e) => SaveTask();

            // Cancel button
            Button cancelButton = new Button();
            cancelButton.Text = "Cancel";
            cancelButton.Size = new Size(80, 30);
            cancelButton.Location = new Point(180, 120);
            cancelButton.Click += (s, e) => this.Close(); // <-- Just closes the form

            // Add controls to the form
            this.Controls.Add(taskLabel);
            this.Controls.Add(taskTextBox);
            this.Controls.Add(saveButton);
            this.Controls.Add(cancelButton);



        }

        public void SetInitialTaskText(string text)
        {
            taskTextBox.Text = text;
        }


        private void SaveTask()
        {
            if (string.IsNullOrEmpty(taskTextBox.Text))
            {
                MessageBox.Show("Task cannot be empty.");
                return;
            }
            UpdatedTask = taskTextBox.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            UpdatedTask = taskTextBox.Text.Trim();
            if (string.IsNullOrEmpty(UpdatedTask))
            {
                MessageBox.Show("Task cannot be empty.");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
