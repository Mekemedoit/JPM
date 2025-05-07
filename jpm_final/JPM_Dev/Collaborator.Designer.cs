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
            button3 = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            panel4 = new Panel();
            label3 = new Label();
            button2 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel3 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            Backlogtxt = new Label();
            addTaskButton = new Button();
            taskListPanel = new FlowLayoutPanel();
            ChatButton = new Button();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(1049, 607);
            button3.Name = "button3";
            button3.Size = new Size(336, 40);
            button3.TabIndex = 17;
            button3.Text = "+ ADD NEW TASK\n\n";
            button3.UseVisualStyleBackColor = true;
            button3.Click += addDone_Click;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoScroll = true;
            flowLayoutPanel3.BackColor = Color.White;
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(1049, 58);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(336, 543);
            flowLayoutPanel3.TabIndex = 13;
            flowLayoutPanel3.WrapContents = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gold;
            panel4.Controls.Add(label3);
            panel4.Location = new Point(1049, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(336, 40);
            panel4.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(131, 3);
            label3.Name = "label3";
            label3.Size = new Size(81, 37);
            label3.TabIndex = 3;
            label3.Text = "Done";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(707, 607);
            button2.Name = "button2";
            button2.Size = new Size(336, 40);
            button2.TabIndex = 16;
            button2.Text = "+ ADD NEW TASK\n\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += addInProgress_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.BackColor = Color.White;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(707, 58);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(336, 543);
            flowLayoutPanel2.TabIndex = 10;
            flowLayoutPanel2.WrapContents = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Orange;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(707, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(336, 40);
            panel3.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(111, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 37);
            label2.TabIndex = 2;
            label2.Text = "In Progress";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(365, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(336, 40);
            panel2.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(138, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 37);
            label1.TabIndex = 1;
            label1.Text = "To Do";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(365, 607);
            button1.Name = "button1";
            button1.Size = new Size(336, 40);
            button1.TabIndex = 12;
            button1.Text = "+ ADD NEW TASK\n\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += addTodoButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(365, 58);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(336, 543);
            flowLayoutPanel1.TabIndex = 8;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumPurple;
            panel1.Controls.Add(Backlogtxt);
            panel1.Location = new Point(23, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 40);
            panel1.TabIndex = 9;
            // 
            // Backlogtxt
            // 
            Backlogtxt.AutoSize = true;
            Backlogtxt.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Backlogtxt.Location = new Point(115, 0);
            Backlogtxt.Name = "Backlogtxt";
            Backlogtxt.Size = new Size(123, 37);
            Backlogtxt.TabIndex = 0;
            Backlogtxt.Text = "Back Log";
            // 
            // addTaskButton
            // 
            addTaskButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addTaskButton.Location = new Point(23, 607);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(336, 40);
            addTaskButton.TabIndex = 6;
            addTaskButton.Text = "+ ADD NEW TASK\n\n";
            addTaskButton.UseVisualStyleBackColor = true;
            addTaskButton.Click += addTaskButton_Click;
            // 
            // taskListPanel
            // 
            taskListPanel.AutoScroll = true;
            taskListPanel.BackColor = Color.White;
            taskListPanel.FlowDirection = FlowDirection.TopDown;
            taskListPanel.Location = new Point(23, 58);
            taskListPanel.Name = "taskListPanel";
            taskListPanel.Size = new Size(336, 543);
            taskListPanel.TabIndex = 7;
            taskListPanel.WrapContents = false;
            // 
            // ChatButton
            // 
            ChatButton.Location = new Point(1407, 82);
            ChatButton.Name = "ChatButton";
            ChatButton.Size = new Size(75, 23);
            ChatButton.TabIndex = 18;
            ChatButton.Text = "Chat";
            ChatButton.UseVisualStyleBackColor = true;
            ChatButton.Click += ChatButton_Click;
            // 
            // Collaborator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1494, 659);
            Controls.Add(ChatButton);
            Controls.Add(button3);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(panel4);
            Controls.Add(button2);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(addTaskButton);
            Controls.Add(taskListPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Collaborator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Collaborator";
            Load += Collaborator_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private FlowLayoutPanel flowLayoutPanel3;
        private Panel panel4;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel3;
        private Panel panel2;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button addTaskButton;
        private FlowLayoutPanel taskListPanel;
        private Label label1;
        private Label Backlogtxt;
        private Label label2;
        private Label label3;
        private Button ChatButton;
    }
}