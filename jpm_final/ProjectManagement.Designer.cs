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
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            search = new Button();
            textBox1 = new TextBox();
            panel3 = new Panel();
            button1 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(930, 549);
            dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(66, 102);
            button2.Name = "button2";
            button2.Size = new Size(117, 59);
            button2.TabIndex = 6;
            button2.Text = "DRAFT";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(66, 185);
            button3.Name = "button3";
            button3.Size = new Size(117, 59);
            button3.TabIndex = 7;
            button3.Text = "IN PROGRESS";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(66, 293);
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
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(11, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 706);
            panel1.TabIndex = 9;
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
            // panel3
            // 
            panel3.BackColor = SystemColors.HighlightText;
            panel3.Location = new Point(284, 98);
            panel3.Name = "panel3";
            panel3.Size = new Size(930, 75);
            panel3.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Location = new Point(964, 58);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 11;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkMagenta;
            button5.Location = new Point(1045, 58);
            button5.Name = "button5";
            button5.Size = new Size(75, 34);
            button5.TabIndex = 12;
            button5.Text = "Edit ";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DodgerBlue;
            button6.Location = new Point(1126, 58);
            button6.Name = "button6";
            button6.Size = new Size(75, 34);
            button6.TabIndex = 13;
            button6.Text = "Delete";
            button6.UseVisualStyleBackColor = false;
            // 
            // ProjectManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 730);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "ProjectManagement";
            Text = "ProjectManagement";
            Load += ProjectManagement_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private Panel panel3;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button search;
        private Button button1;
        private Button button5;
        private Button button6;
    }
}