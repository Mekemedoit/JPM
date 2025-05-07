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
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            search = new Button();
            textBox1 = new TextBox();
            panel3 = new Panel();

            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();

            // Close button
            button1.Text = "Close";
            button1.Dock = DockStyle.Right;
            button1.Width = 117;
            button1.Click += button1_Click;

            // panel2 (Main content panel)
            panel2.BackColor = Color.Lavender;
            panel2.Dock = DockStyle.Fill;
            panel2.Controls.Add(dataGridView1);

            // dataGridView1 inside panel2
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // Top buttons
            button2.Text = "DRAFT";
            button3.Text = "IN PROGRESS";
            button4.Text = "COMPLETE";

            button2.Width = button3.Width = button4.Width = 117;
            button2.Height = button3.Height = button4.Height = 40;

            // Arrange top buttons horizontally inside panel3
            FlowLayoutPanel topButtonPanel = new FlowLayoutPanel();
            topButtonPanel.Dock = DockStyle.Top;
            topButtonPanel.Height = 60;
            topButtonPanel.Padding = new Padding(10, 10, 0, 0);
            topButtonPanel.Controls.Add(button2);
            topButtonPanel.Controls.Add(button3);
            topButtonPanel.Controls.Add(button4);
            topButtonPanel.Controls.Add(button1); // Close button at end

            // Left sidebar panel1
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Dock = DockStyle.Left;
            panel1.Width = 267;
            panel1.Controls.Add(search);
            panel1.Controls.Add(textBox1);

            // Search box
            textBox1.Top = 13;
            textBox1.Left = 4;
            textBox1.Width = 179;

            search.Text = "Search";
            search.Top = 13;
            search.Left = 189;
            search.Width = 75;

            // Optional top panel (panel3)
            panel3.Dock = DockStyle.Top;
            panel3.Height = 20;
            panel3.BackColor = SystemColors.HighlightText;

            // Form settings
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 724);
            Controls.Add(panel2);
            Controls.Add(topButtonPanel);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Text = "ProjectManagement";
            Load += ProjectManagement_Load;

            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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