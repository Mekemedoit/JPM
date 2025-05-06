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
    public partial class AddTask : Form
    {
        public AddTask()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Collect data from the form
            string taskName = nameTxt.Text.Trim();
            string taskDetails = detsTxt.Text.Trim();
            string deadline = deadlineTxt.Text.Trim();
            string assignedTo = assignedToTxt.Text.Trim();
            string priority = priorityTxt.Text.Trim();

            // Optional: Combine with date picker value if needed
            string assignedDate = assignedDatePick.Value.ToShortDateString();

            // Simple validation
            if (string.IsNullOrWhiteSpace(taskName) || string.IsNullOrWhiteSpace(taskDetails) ||
                string.IsNullOrWhiteSpace(deadline) || string.IsNullOrWhiteSpace(assignedTo) ||
                string.IsNullOrWhiteSpace(priority))
            {
                MessageBox.Show("Please fill in all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Build line to write
            string taskLine = $"{taskName},{taskDetails},{deadline},{assignedTo},{priority},{assignedDate}";

            // Write to file
            try
            {
                string path = "tasks.txt";
                File.AppendAllText(path, taskLine + Environment.NewLine);

                MessageBox.Show("Task saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving task: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to clear the fields after saving
        private void ClearFields()
        {
            nameTxt.Clear();
            detsTxt.Clear();
            deadlineTxt.Clear();
            assignedToTxt.Clear();
            priorityTxt.Clear();
            assignedDatePick.Value = DateTime.Now;
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
