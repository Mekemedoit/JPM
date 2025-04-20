namespace JPM_Dev
{
    partial class Collaborator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            taskListPanel = new FlowLayoutPanel();
            addTaskButton = new Button();
            SuspendLayout();
            // 
            // taskListPanel
            // 
            taskListPanel.AutoScroll = true;
            taskListPanel.BackColor = Color.WhiteSmoke;
            taskListPanel.FlowDirection = FlowDirection.TopDown;
            taskListPanel.Location = new Point(20, 20);
            taskListPanel.Name = "taskListPanel";
            taskListPanel.Size = new Size(300, 503);
            taskListPanel.TabIndex = 0;
            taskListPanel.WrapContents = false;
            // 
            // addTaskButton
            // 
            addTaskButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addTaskButton.Location = new Point(20, 529);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(300, 40);
            addTaskButton.TabIndex = 0;
            addTaskButton.Text = "+ ADD NEW TASK";
            addTaskButton.UseVisualStyleBackColor = true;
            addTaskButton.Click += addTaskButton_Click;
            // 
            // Collaborator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 581);
            Controls.Add(addTaskButton);
            Controls.Add(taskListPanel);
            Name = "Collaborator";
            Text = "Collaborator";
            Load += Collaborator_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel taskListPanel;
        private Button addTaskButton;
    }
}