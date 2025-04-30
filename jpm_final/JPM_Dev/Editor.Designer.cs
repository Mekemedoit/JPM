namespace JPM_Dev
{
    partial class Editor
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
            BacklogPanel = new Panel();
            Backlogtxt = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            toDoPanel = new Panel();
            label1 = new Label();
            inProgressPanel = new Panel();
            label2 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button2 = new Button();
            donePanel = new Panel();
            label3 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            button3 = new Button();
            ChatButton = new Button();
            BacklogPanel.SuspendLayout();
            toDoPanel.SuspendLayout();
            inProgressPanel.SuspendLayout();
            donePanel.SuspendLayout();
            SuspendLayout();
            // 
            // taskListPanel
            // 
            taskListPanel.AutoScroll = true;
            taskListPanel.BackColor = Color.White;
            taskListPanel.FlowDirection = FlowDirection.TopDown;
            taskListPanel.Location = new Point(17, 97);
            taskListPanel.Margin = new Padding(4, 5, 4, 5);
            taskListPanel.Name = "taskListPanel";
            taskListPanel.Size = new Size(480, 905);
            taskListPanel.TabIndex = 0;
            taskListPanel.WrapContents = false;
            // 
            // addTaskButton
            // 
            addTaskButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addTaskButton.Location = new Point(17, 1012);
            addTaskButton.Margin = new Padding(4, 5, 4, 5);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(480, 67);
            addTaskButton.TabIndex = 0;
            addTaskButton.Text = "+ ADD NEW TASK\n\n";
            addTaskButton.UseVisualStyleBackColor = true;
            addTaskButton.Click += addTaskButton_Click;
            // 
            // BacklogPanel
            // 
            BacklogPanel.BackColor = Color.MediumPurple;
            BacklogPanel.Controls.Add(Backlogtxt);
            BacklogPanel.Location = new Point(17, 20);
            BacklogPanel.Margin = new Padding(4, 5, 4, 5);
            BacklogPanel.Name = "BacklogPanel";
            BacklogPanel.Size = new Size(480, 67);
            BacklogPanel.TabIndex = 1;
            // 
            // Backlogtxt
            // 
            Backlogtxt.AutoSize = true;
            Backlogtxt.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Backlogtxt.Location = new Point(167, 5);
            Backlogtxt.Margin = new Padding(4, 0, 4, 0);
            Backlogtxt.Name = "Backlogtxt";
            Backlogtxt.Size = new Size(186, 55);
            Backlogtxt.TabIndex = 6;
            Backlogtxt.Text = "Back Log";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(506, 97);
            flowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(480, 905);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(506, 1012);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(480, 67);
            button1.TabIndex = 2;
            button1.Text = "+ ADD NEW TASK\n\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += addTodoButton_Click;
            // 
            // toDoPanel
            // 
            toDoPanel.BackColor = Color.DodgerBlue;
            toDoPanel.Controls.Add(label1);
            toDoPanel.Location = new Point(506, 20);
            toDoPanel.Margin = new Padding(4, 5, 4, 5);
            toDoPanel.Name = "toDoPanel";
            toDoPanel.Size = new Size(480, 67);
            toDoPanel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(184, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 55);
            label1.TabIndex = 7;
            label1.Text = "To Do";
            // 
            // inProgressPanel
            // 
            inProgressPanel.BackColor = Color.Orange;
            inProgressPanel.Controls.Add(label2);
            inProgressPanel.Location = new Point(994, 20);
            inProgressPanel.Margin = new Padding(4, 5, 4, 5);
            inProgressPanel.Name = "inProgressPanel";
            inProgressPanel.Size = new Size(480, 67);
            inProgressPanel.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(134, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(223, 55);
            label2.TabIndex = 8;
            label2.Text = "In Progress";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.BackColor = Color.White;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(994, 97);
            flowLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(480, 905);
            flowLayoutPanel2.TabIndex = 2;
            flowLayoutPanel2.WrapContents = false;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(994, 1012);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(480, 67);
            button2.TabIndex = 4;
            button2.Text = "+ ADD NEW TASK\n\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += addInProgress_Click;
            // 
            // donePanel
            // 
            donePanel.BackColor = Color.Gold;
            donePanel.Controls.Add(label3);
            donePanel.Location = new Point(1483, 20);
            donePanel.Margin = new Padding(4, 5, 4, 5);
            donePanel.Name = "donePanel";
            donePanel.Size = new Size(480, 67);
            donePanel.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(191, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(121, 55);
            label3.TabIndex = 9;
            label3.Text = "Done";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoScroll = true;
            flowLayoutPanel3.BackColor = Color.White;
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(1483, 97);
            flowLayoutPanel3.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(480, 905);
            flowLayoutPanel3.TabIndex = 3;
            flowLayoutPanel3.WrapContents = false;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(1483, 1012);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(480, 67);
            button3.TabIndex = 5;
            button3.Text = "+ ADD NEW TASK\n\n";
            button3.UseVisualStyleBackColor = true;
            button3.Click += addDone_Click;
            // 
            // ChatButton
            // 
            ChatButton.Location = new Point(1987, 97);
            ChatButton.Margin = new Padding(4, 5, 4, 5);
            ChatButton.Name = "ChatButton";
            ChatButton.Size = new Size(107, 38);
            ChatButton.TabIndex = 6;
            ChatButton.Text = "Chat";
            ChatButton.UseVisualStyleBackColor = true;
            ChatButton.Click += ChatButton_Click;
            // 
            // Editor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2111, 1098);
            Controls.Add(ChatButton);
            Controls.Add(button3);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(donePanel);
            Controls.Add(button2);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(inProgressPanel);
            Controls.Add(toDoPanel);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(BacklogPanel);
            Controls.Add(addTaskButton);
            Controls.Add(taskListPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Editor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editor";
            Load += Editor_Load;
            BacklogPanel.ResumeLayout(false);
            BacklogPanel.PerformLayout();
            toDoPanel.ResumeLayout(false);
            toDoPanel.PerformLayout();
            inProgressPanel.ResumeLayout(false);
            inProgressPanel.PerformLayout();
            donePanel.ResumeLayout(false);
            donePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel taskListPanel;
        private Button addTaskButton;
        private Panel BacklogPanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Panel toDoPanel;
        private Panel inProgressPanel;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button2;
        private Panel donePanel;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button button3;
        private Label Backlogtxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button ChatButton;
    }
}