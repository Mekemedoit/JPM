namespace JPM_Dev
{
    partial class ProjectManagement
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
            button1 = new Button();
            panel2 = new Panel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            search = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1097, 34);
            button1.Name = "button1";
            button1.Size = new Size(117, 59);
            button1.TabIndex = 0;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lavender;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(284, 98);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(930, 620);
            panel2.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(474, 34);
            button2.Name = "button2";
            button2.Size = new Size(117, 59);
            button2.TabIndex = 6;
            button2.Text = "DRAFT";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(662, 34);
            button3.Name = "button3";
            button3.Size = new Size(117, 59);
            button3.TabIndex = 7;
            button3.Text = "IN PROGRESS";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(865, 34);
            button4.Name = "button4";
            button4.Size = new Size(117, 59);
            button4.TabIndex = 8;
            button4.Text = "COMPLETE";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(search);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(11, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 706);
            panel1.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HighlightText;
            panel3.Location = new Point(284, 98);
            panel3.Name = "panel3";
            panel3.Size = new Size(930, 75);
            panel3.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(4, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 23);
            textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(930, 549);
            dataGridView1.TabIndex = 0;
            // 
            // search
            // 
            search.Location = new Point(189, 13);
            search.Name = "search";
            search.Size = new Size(75, 23);
            search.TabIndex = 1;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            // 
            // ProjectManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 730);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel2);
            Controls.Add(button1);
            Name = "ProjectManagement";
            Text = "ProjectManagement";
            Load += ProjectManagement_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private Panel panel3;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button search;
    }
}