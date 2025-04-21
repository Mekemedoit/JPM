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
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button2 = new Button();
            panel4 = new Panel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            button3 = new Button();
            SuspendLayout();
            // 
            // taskListPanel
            // 
            taskListPanel.AutoScroll = true;
            taskListPanel.BackColor = Color.White;
            taskListPanel.FlowDirection = FlowDirection.TopDown;
            taskListPanel.Location = new Point(12, 58);
            taskListPanel.Name = "taskListPanel";
            taskListPanel.Size = new Size(336, 543);
            taskListPanel.TabIndex = 0;
            taskListPanel.WrapContents = false;
            // 
            // addTaskButton
            // 
            addTaskButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addTaskButton.Location = new Point(12, 607);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(336, 40);
            addTaskButton.TabIndex = 0;
            addTaskButton.Text = "+ ADD NEW TASK\n\n";
            addTaskButton.UseVisualStyleBackColor = true;
            addTaskButton.Click += addTaskButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumPurple;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 40);
            panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(354, 58);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(336, 543);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(354, 607);
            button1.Name = "button1";
            button1.Size = new Size(336, 40);
            button1.TabIndex = 2;
            button1.Text = "+ ADD NEW TASK\n\n";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Location = new Point(354, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(336, 40);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Orange;
            panel3.Location = new Point(696, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(336, 40);
            panel3.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.BackColor = Color.White;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(696, 58);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(336, 543);
            flowLayoutPanel2.TabIndex = 2;
            flowLayoutPanel2.WrapContents = false;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(696, 607);
            button2.Name = "button2";
            button2.Size = new Size(336, 40);
            button2.TabIndex = 4;
            button2.Text = "+ ADD NEW TASK\n\n";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gold;
            panel4.Location = new Point(1038, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(336, 40);
            panel4.TabIndex = 4;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoScroll = true;
            flowLayoutPanel3.BackColor = Color.White;
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(1038, 58);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(336, 543);
            flowLayoutPanel3.TabIndex = 3;
            flowLayoutPanel3.WrapContents = false;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(1038, 607);
            button3.Name = "button3";
            button3.Size = new Size(336, 40);
            button3.TabIndex = 5;
            button3.Text = "+ ADD NEW TASK\n\n";
            button3.UseVisualStyleBackColor = true;
            // 
            // Editor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1473, 659);
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
            Name = "Editor";
            Text = "Editor";
            Load += Editor_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel taskListPanel;
        private Button addTaskButton;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button2;
        private Panel panel4;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button button3;
    }
}