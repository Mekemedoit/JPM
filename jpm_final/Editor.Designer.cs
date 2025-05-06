namespace JPM_Dev
{
    partial class Editor

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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            report = new Button();
            project = new Button();
            task = new Button();
            user = new PictureBox();
            notification = new PictureBox();
            chat = new PictureBox();
            panelMain = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editProfileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)user).BeginInit();
            ((System.ComponentModel.ISupportInitialize)notification).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chat).BeginInit();
            contextMenuStrip1.SuspendLayout();
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
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 554);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 507);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(199, 15);
            label1.TabIndex = 0;
            label1.Text = "© Jmarian Publication Management";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.jmarian_logo;
            pictureBox1.Location = new Point(53, 36);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // report
            // 
            report.BackColor = Color.DarkMagenta;
            report.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            report.ForeColor = SystemColors.Control;
            report.Location = new Point(24, 331);
            report.Margin = new Padding(2);
            report.Name = "report";
            report.Size = new Size(210, 42);
            report.TabIndex = 4;
            report.Text = "Report Monitoring";
            report.UseVisualStyleBackColor = false;
            report.Click += report_Click;
            // 
            // project
            // 
            project.BackColor = Color.DarkMagenta;
            project.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            project.ForeColor = SystemColors.Control;
            project.Location = new Point(24, 270);
            project.Margin = new Padding(2);
            project.Name = "project";
            project.Size = new Size(210, 42);
            project.TabIndex = 3;
            project.Text = "Project Management";
            project.UseVisualStyleBackColor = false;
            project.Click += project_Click;
            // 
            // task
            // 
            task.BackColor = Color.DarkMagenta;
            task.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            task.ForeColor = SystemColors.Control;
            task.Location = new Point(24, 207);
            task.Margin = new Padding(2);
            task.Name = "task";
            task.Size = new Size(210, 42);
            task.TabIndex = 2;
            task.Text = "Task Management";
            task.UseVisualStyleBackColor = false;
            task.Click += task_Click;
            // 
            // user
            // 
            user.Image = Properties.Resources.user;
            user.Location = new Point(1062, 21);
            user.Margin = new Padding(2);
            user.Name = "user";
            user.Size = new Size(32, 28);
            user.SizeMode = PictureBoxSizeMode.StretchImage;
            user.TabIndex = 1;
            user.TabStop = false;
            user.Click += user_Click;
            // 
            // notification
            // 
            notification.Image = Properties.Resources.notification;
            notification.Location = new Point(1023, 21);
            notification.Margin = new Padding(2);
            notification.Name = "notification";
            notification.Size = new Size(35, 28);
            notification.SizeMode = PictureBoxSizeMode.StretchImage;
            notification.TabIndex = 2;
            notification.TabStop = false;
            // 
            // chat
            // 
            chat.Image = Properties.Resources.chat;
            chat.Location = new Point(978, 21);
            chat.Margin = new Padding(2);
            chat.Name = "chat";
            chat.Size = new Size(41, 28);
            chat.SizeMode = PictureBoxSizeMode.StretchImage;
            chat.TabIndex = 3;
            chat.TabStop = false;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.Lavender;
            panelMain.Location = new Point(316, 64);
            panelMain.Margin = new Padding(2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(778, 491);
            panelMain.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editProfileToolStripMenuItem, logoutToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(132, 48);
            // 
            // editProfileToolStripMenuItem
            // 
            editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            editProfileToolStripMenuItem.Size = new Size(131, 22);
            editProfileToolStripMenuItem.Text = "Edit Profile";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(131, 22);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click_1;
            // 
            // Editor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1127, 569);
            Controls.Add(panelMain);
            Controls.Add(chat);
            Controls.Add(notification);
            Controls.Add(user);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Editor";
            Text = "Editor";
            Load += Editor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)user).EndInit();
            ((System.ComponentModel.ISupportInitialize)notification).EndInit();
            ((System.ComponentModel.ISupportInitialize)chat).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button report;
        private Button project;
        private Button task;
        private PictureBox pictureBox1;
        private PictureBox user;
        private PictureBox notification;
        private PictureBox chat;
        private Panel panelMain;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editProfileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}