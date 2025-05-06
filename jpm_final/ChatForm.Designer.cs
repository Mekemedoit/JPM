namespace JPM_Dev
{
    partial class ChatForm
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
            PanelSidebar = new Panel();
            panelTopbar = new Panel();
            panelMain = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button10 = new Button();
            PanelSidebar.SuspendLayout();
            panelTopbar.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // PanelSidebar
            // 
            PanelSidebar.BackColor = Color.DarkGray;
            PanelSidebar.Controls.Add(button4);
            PanelSidebar.Controls.Add(button3);
            PanelSidebar.Controls.Add(button2);
            PanelSidebar.Controls.Add(button1);
            PanelSidebar.Dock = DockStyle.Left;
            PanelSidebar.Location = new Point(0, 0);
            PanelSidebar.Name = "PanelSidebar";
            PanelSidebar.Size = new Size(200, 795);
            PanelSidebar.TabIndex = 0;
            // 
            // panelTopbar
            // 
            panelTopbar.BackColor = Color.SteelBlue;
            panelTopbar.Controls.Add(button9);
            panelTopbar.Controls.Add(button8);
            panelTopbar.Controls.Add(button7);
            panelTopbar.Controls.Add(button6);
            panelTopbar.Controls.Add(button5);
            panelTopbar.Dock = DockStyle.Top;
            panelTopbar.Location = new Point(200, 0);
            panelTopbar.Name = "panelTopbar";
            panelTopbar.Size = new Size(1260, 60);
            panelTopbar.TabIndex = 1;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(button10);
            panelMain.Controls.Add(textBox2);
            panelMain.Controls.Add(textBox1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(200, 60);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1260, 735);
            panelMain.TabIndex = 2;
            panelMain.Paint += panelMain_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(12, 191);
            button1.Name = "button1";
            button1.Size = new Size(153, 34);
            button1.TabIndex = 0;
            button1.Text = "Workplace";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 260);
            button2.Name = "button2";
            button2.Size = new Size(153, 34);
            button2.TabIndex = 1;
            button2.Text = "Collaboration";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 329);
            button3.Name = "button3";
            button3.Size = new Size(153, 34);
            button3.TabIndex = 2;
            button3.Text = "Projects";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 399);
            button4.Name = "button4";
            button4.Size = new Size(153, 34);
            button4.TabIndex = 3;
            button4.Text = "Roadmaps";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(27, 12);
            button5.Name = "button5";
            button5.Size = new Size(90, 31);
            button5.TabIndex = 0;
            button5.Text = "List View";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(123, 12);
            button6.Name = "button6";
            button6.Size = new Size(90, 31);
            button6.TabIndex = 1;
            button6.Text = "Add";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(219, 12);
            button7.Name = "button7";
            button7.Size = new Size(154, 31);
            button7.TabIndex = 2;
            button7.Text = "Batch Update";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(379, 12);
            button8.Name = "button8";
            button8.Size = new Size(90, 31);
            button8.TabIndex = 3;
            button8.Text = "Report";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(485, 12);
            button9.Name = "button9";
            button9.Size = new Size(109, 31);
            button9.TabIndex = 4;
            button9.Text = "Dashboard";
            button9.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 21);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(321, 599);
            textBox1.TabIndex = 0;
            textBox1.Text = "ChatHistory";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Bottom;
            textBox2.Location = new Point(0, 704);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(1260, 31);
            textBox2.TabIndex = 1;
            textBox2.Text = "Message";
            // 
            // button10
            // 
            button10.Location = new Point(1187, 704);
            button10.Name = "button10";
            button10.Size = new Size(73, 32);
            button10.TabIndex = 2;
            button10.Text = "Send";
            button10.UseVisualStyleBackColor = true;
            // 
            // ChatForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1460, 795);
            Controls.Add(panelMain);
            Controls.Add(panelTopbar);
            Controls.Add(PanelSidebar);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ChatForm";
            Text = "ChatForm";
            Load += ChatForm_Load;
            PanelSidebar.ResumeLayout(false);
            panelTopbar.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelSidebar;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panelTopbar;
        private Panel panelMain;
        private Button button5;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private TextBox textBox1;
        private Button button10;
        private TextBox textBox2;
    }
}