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
            txtRole = new TextBox();
            txtEmail = new TextBox();
            saveBtn = new Button();
            txtPass = new TextBox();
            picProfile = new Button();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(38, 72);
            txtFirstName.Margin = new Padding(2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(395, 27);
            txtFirstName.TabIndex = 0;
            txtFirstName.Text = "First Name";
            //txtFirstName.TextChanged += txtFirstName;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(38, 125);
            txtLastName.Margin = new Padding(2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(395, 27);
            txtLastName.TabIndex = 1;
            txtLastName.Text = "Last Name";
            //txtLastName.TextChanged += txtLastName;
            // 
            // txtRole
            // 
            txtRole.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRole.Location = new Point(38, 181);
            txtRole.Margin = new Padding(2);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(395, 27);
            txtRole.TabIndex = 2;
            txtRole.Text = "Role";
            //txtRole.TextChanged += txtRole;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(38, 237);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(395, 27);
            txtEmail.TabIndex = 3;
            txtEmail.Text = "Email Address";
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
            txtPass.Size = new Size(395, 27);
            txtPass.TabIndex = 5;
            txtPass.Text = "Password";
            // 
            // picProfile
            // 
            picProfile.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            picProfile.Location = new Point(552, 72);
            picProfile.Name = "picProfile";
            picProfile.Size = new Size(158, 136);
            picProfile.TabIndex = 6;
            picProfile.Text = "Attach Photo";
            picProfile.UseVisualStyleBackColor = true;
            // 
            // ProfileManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(767, 436);
            Controls.Add(picProfile);
            Controls.Add(txtPass);
            Controls.Add(saveBtn);
            Controls.Add(txtEmail);
            Controls.Add(txtRole);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Margin = new Padding(2);
            Name = "ProfileManagement";
            Load += ProfileManagement_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtRole;
        private TextBox txtEmail;
        private Button saveBtn;
        private TextBox txtPass;
        private Button picProfile;
    }
}
