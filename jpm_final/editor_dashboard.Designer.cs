namespace JPM_Dev
{
    partial class editor_dashboard
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
            panel3 = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Location = new Point(229, 47);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 366);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // panel5
            // 
            panel5.Location = new Point(446, 47);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 366);
            panel5.TabIndex = 4;
            // 
            // label1
            // 
            label1.BackColor = Color.DarkMagenta;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(200, 30);
            label1.TabIndex = 6;
            label1.Text = "BACKLOG";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.DarkMagenta;
            label2.Location = new Point(229, 9);
            label2.Name = "label2";
            label2.Size = new Size(200, 30);
            label2.TabIndex = 7;
            label2.Text = "To Do";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.DarkMagenta;
            label3.Location = new Point(446, 9);
            label3.Name = "label3";
            label3.Size = new Size(200, 30);
            label3.TabIndex = 8;
            label3.Text = "In Progress";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Location = new Point(665, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 366);
            panel2.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoEllipsis = true;
            label4.BackColor = Color.DarkMagenta;
            label4.Location = new Point(665, 9);
            label4.Name = "label4";
            label4.Size = new Size(200, 30);
            label4.TabIndex = 10;
            label4.Text = "DONE";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(12, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 366);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint_1;
            // 
            // label6
            // 
            label6.Location = new Point(34, 18);
            label6.Name = "label6";
            label6.Size = new Size(116, 32);
            label6.TabIndex = 1;
            label6.Text = "Generate application landscape";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 18);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 0;
            label5.Text = "YOU:";
            label5.Click += label5_Click;
            // 
            // editor_dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 450);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Name = "editor_dashboard";
            Text = "editor_dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Panel panel5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private Panel panel1;
        private Label label5;
        private Label label6;
    }
}