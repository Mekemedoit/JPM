namespace JPM_Dev
{
    partial class ProfileManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            saveBtn = new Button();
            txtPass = new TextBox();
            picProfile = new PictureBox();
            cmbRole = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(38, 72);
            txtFirstName.Margin = new Padding(2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name";
            txtFirstName.Size = new Size(395, 27);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(38, 125);
            txtLastName.Margin = new Padding(2);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(395, 27);
            txtLastName.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(38, 237);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(395, 27);
            txtEmail.TabIndex = 3;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.DarkMagenta;
            saveBtn.Location = new Point(371, 348);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(117, 61);
            saveBtn.TabIndex = 4;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(38, 293);
            txtPass.Margin = new Padding(2);
            txtPass.Name = "txtPass";
            txtPass.PlaceholderText = "Password";
            txtPass.Size = new Size(395, 27);
            txtPass.TabIndex = 5;
            // 
            // picProfile
            // 
            picProfile.BackColor = Color.WhiteSmoke;
            picProfile.BorderStyle = BorderStyle.FixedSingle;
            picProfile.Location = new Point(552, 72);
            picProfile.Name = "picProfile";
            picProfile.Size = new Size(158, 136);
            picProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            picProfile.TabIndex = 6;
            picProfile.TabStop = false;
            picProfile.Click += btnAttachPhoto_Click;
            // 
            // cmbRole
            // 
            cmbRole.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Editor", "Collaborator" });
            cmbRole.Location = new Point(38, 179);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(285, 29);
            cmbRole.TabIndex = 7;
            // 
            // ProfileManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(767, 436);
            Controls.Add(cmbRole);
            Controls.Add(picProfile);
            Controls.Add(txtPass);
            Controls.Add(saveBtn);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Margin = new Padding(2);
            Name = "ProfileManagement";
            Load += ProfileManagement_Load;
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private Button saveBtn;
        private TextBox txtPass;
        private PictureBox picProfile;
        private ComboBox cmbRole;
    }
}
