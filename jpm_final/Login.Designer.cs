namespace JPM_Dev
{
    partial class Login
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
            loginPanel = new Panel();
            label1 = new Label();
            loginBtn = new Button();
            passwordTxtBox = new TextBox();
            password = new Label();
            userTxtBox = new TextBox();
            email = new Label();
            pictureBox1 = new PictureBox();
            loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginPanel.BackColor = Color.DarkMagenta;
            loginPanel.Controls.Add(label1);
            loginPanel.Controls.Add(loginBtn);
            loginPanel.Controls.Add(passwordTxtBox);
            loginPanel.Controls.Add(password);
            loginPanel.Controls.Add(userTxtBox);
            loginPanel.Controls.Add(email);
            loginPanel.Controls.Add(pictureBox1);
            loginPanel.Location = new Point(426, 103);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(448, 475);
            loginPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(161, 140);
            label1.Name = "label1";
            label1.Size = new Size(167, 36);
            label1.TabIndex = 12;
            label1.Text = "Login Form";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Transparent;
            loginBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.DarkMagenta;
            loginBtn.Location = new Point(189, 349);
            loginBtn.Margin = new Padding(2);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(106, 39);
            loginBtn.TabIndex = 11;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.Font = new Font("Century Gothic", 12F);
            passwordTxtBox.Location = new Point(126, 295);
            passwordTxtBox.Margin = new Padding(2);
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.Size = new Size(282, 27);
            passwordTxtBox.TabIndex = 10;
            passwordTxtBox.UseSystemPasswordChar = true;
            // 
            // password
            // 
            password.AutoSize = true;
            password.BackColor = Color.Transparent;
            password.Font = new Font("Century Gothic", 12F);
            password.ForeColor = SystemColors.ControlLightLight;
            password.Location = new Point(20, 295);
            password.Margin = new Padding(2, 0, 2, 0);
            password.Name = "password";
            password.Size = new Size(86, 21);
            password.TabIndex = 9;
            password.Text = "Password:";
            // 
            // userTxtBox
            // 
            userTxtBox.Font = new Font("Century Gothic", 12F);
            userTxtBox.Location = new Point(126, 226);
            userTxtBox.Margin = new Padding(2);
            userTxtBox.Name = "userTxtBox";
            userTxtBox.Size = new Size(282, 27);
            userTxtBox.TabIndex = 8;
            // 
            // email
            // 
            email.AutoSize = true;
            email.BackColor = Color.Transparent;
            email.Font = new Font("Century Gothic", 12F);
            email.ForeColor = SystemColors.ControlLightLight;
            email.Location = new Point(20, 226);
            email.Margin = new Padding(2, 0, 2, 0);
            email.Name = "email";
            email.Size = new Size(55, 21);
            email.TabIndex = 7;
            email.Text = "Email:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.circlebg;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.jmarian_logo;
            pictureBox1.Location = new Point(179, 30);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1320, 673);
            Controls.Add(loginPanel);
            Margin = new Padding(2);
            Name = "Login";
            Text = "Login Form";
            Load += Login_Load;
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Panel loginPanel;
        private Button loginBtn;
        private TextBox passwordTxtBox;
        private Label password;
        private TextBox userTxtBox;
        private Label email;
        private PictureBox pictureBox1;
        private Label label1;
    }
}