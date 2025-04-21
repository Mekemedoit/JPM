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
            button2 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel3 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            addTaskButton = new Button();
            taskListPanel = new FlowLayoutPanel();
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
            panel4.Location = new Point(1049, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(336, 40);
            panel4.TabIndex = 15;
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
            panel3.Location = new Point(707, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(336, 40);
            panel3.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Location = new Point(365, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(336, 40);
            panel2.TabIndex = 11;
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
            panel1.Location = new Point(23, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 40);
            panel1.TabIndex = 9;
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
            // Collaborator
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
            Name = "Collaborator";
            Text = "Collaborator";
            Load += Collaborator_Load;
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
    }
}