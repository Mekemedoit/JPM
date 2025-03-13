namespace JPM_Dev
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            report = new Button();
            project = new Button();
            task = new Button();
            profile = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(report);
            panel1.Controls.Add(project);
            panel1.Controls.Add(task);
            panel1.Controls.Add(profile);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(381, 924);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 845);
            label1.Name = "label1";
            label1.Size = new Size(295, 25);
            label1.TabIndex = 0;
            label1.Text = "© Jmarian Publication Management";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.jmarian_logo;
            pictureBox1.Location = new Point(76, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // report
            // 
            report.BackColor = Color.DarkMagenta;
            report.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            report.ForeColor = SystemColors.Control;
            report.Location = new Point(34, 628);
            report.Name = "report";
            report.Size = new Size(300, 70);
            report.TabIndex = 4;
            report.Text = "Report Monitoring";
            report.UseVisualStyleBackColor = false;
            // 
            // project
            // 
            project.BackColor = Color.DarkMagenta;
            project.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            project.ForeColor = SystemColors.Control;
            project.Location = new Point(34, 528);
            project.Name = "project";
            project.Size = new Size(300, 70);
            project.TabIndex = 3;
            project.Text = "Project Management";
            project.UseVisualStyleBackColor = false;
            // 
            // task
            // 
            task.BackColor = Color.DarkMagenta;
            task.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            task.ForeColor = SystemColors.Control;
            task.Location = new Point(34, 428);
            task.Name = "task";
            task.Size = new Size(300, 70);
            task.TabIndex = 2;
            task.Text = "Task Management";
            task.UseVisualStyleBackColor = false;
            // 
            // profile
            // 
            profile.BackColor = Color.DarkMagenta;
            profile.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            profile.ForeColor = SystemColors.Control;
            profile.Location = new Point(34, 332);
            profile.Name = "profile";
            profile.Size = new Size(300, 70);
            profile.TabIndex = 1;
            profile.Text = "Profile Management";
            profile.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(1529, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.notification;
            pictureBox3.Location = new Point(1477, 35);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.chat;
            pictureBox4.Location = new Point(1422, 35);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(34, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lavender;
            panel2.Location = new Point(451, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(1112, 765);
            panel2.TabIndex = 4;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1619, 920);
            Controls.Add(panel2);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin";
            Text = "Admin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button profile;
        private Button report;
        private Button project;
        private Button task;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel panel2;
        private Label label1;
    }
}