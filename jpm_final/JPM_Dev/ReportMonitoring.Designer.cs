namespace JPM_Dev
{
    partial class ReportMonitoring
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
            panel3 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            search = new Button();
            textBox1 = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1101, 71);
            button1.Name = "button1";
            button1.Size = new Size(117, 57);
            button1.TabIndex = 0;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HighlightText;
            panel3.Location = new Point(288, 135);
            panel3.Name = "panel3";
            panel3.Size = new Size(930, 75);
            panel3.TabIndex = 15;
            // 
            // button4
            // 
            button4.Location = new Point(869, 71);
            button4.Name = "button4";
            button4.Size = new Size(117, 59);
            button4.TabIndex = 14;
            button4.Text = "COMPLETE";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(666, 71);
            button3.Name = "button3";
            button3.Size = new Size(117, 59);
            button3.TabIndex = 13;
            button3.Text = "IN PROGRESS";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(478, 71);
            button2.Name = "button2";
            button2.Size = new Size(117, 59);
            button2.TabIndex = 12;
            button2.Text = "DRAFT";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lavender;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(288, 135);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(930, 620);
            panel2.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(930, 549);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(search);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(12, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 706);
            panel1.TabIndex = 16;
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
            // textBox1
            // 
            textBox1.Location = new Point(4, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 23);
            textBox1.TabIndex = 0;
            // 
            // ReportMonitoring
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 769);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel2);
            Controls.Add(button1);
            Name = "ReportMonitoring";
            Text = "ReportMonitoring";
            Load += ReportMonitoring_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel3;
        private Button button4;
        private Button button3;
        private Button button2;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button search;
        private TextBox textBox1;
    }
}