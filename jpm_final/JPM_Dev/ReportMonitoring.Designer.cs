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
            panel3 = new Panel();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            search = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button1 = new Button();

            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();

            // Top spacing panel
            panel3.Dock = DockStyle.Top;
            panel3.Height = 20;
            panel3.BackColor = SystemColors.HighlightText;

            // Main data panel
            panel2.Dock = DockStyle.Fill;
            panel2.BackColor = Color.Lavender;
            panel2.Controls.Add(dataGridView1);

            // DataGridView setup
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // Sidebar panel
            panel1.Dock = DockStyle.Left;
            panel1.Width = 267;
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(search);
            panel1.Controls.Add(textBox1);

            // Search textbox
            textBox1.Top = 13;
            textBox1.Left = 4;
            textBox1.Width = 179;

            // Search button
            search.Top = 13;
            search.Left = 189;
            search.Width = 75;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;

            // Top buttons: DRAFT, IN PROGRESS, COMPLETE, CLOSE
            button2.Text = "DRAFT";
            button3.Text = "IN PROGRESS";
            button4.Text = "COMPLETE";
            button1.Text = "Close";

            Button[] topButtons = { button2, button3, button4, button1 };
            foreach (var btn in topButtons)
            {
                btn.Width = 117;
                btn.Height = 59;
                btn.UseVisualStyleBackColor = true;
            }

            button1.Click += button1_Click;

            FlowLayoutPanel topButtonPanel = new FlowLayoutPanel();
            topButtonPanel.Dock = DockStyle.Top;
            topButtonPanel.Height = 75;
            topButtonPanel.Padding = new Padding(10, 10, 0, 0);
            topButtonPanel.Controls.Add(button2);
            topButtonPanel.Controls.Add(button3);
            topButtonPanel.Controls.Add(button4);
            topButtonPanel.Controls.Add(button1);

            // Form settings
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 711);
            Controls.Add(panel2);
            Controls.Add(topButtonPanel);
            Controls.Add(panel3);
            Controls.Add(panel1);
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
        private Panel panel3;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button search;
        private TextBox textBox1;
        private Button button4;
        private Button button3;
        private Button button1;
        private Button button2;
    }
}