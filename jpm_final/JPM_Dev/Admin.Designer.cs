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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            report = new Button();
            project = new Button();
            task = new Button();
            profile = new Button();
            user = new PictureBox();
            notification = new PictureBox();
            chat = new PictureBox();
            panel2 = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            addProjectToolStripMenuItem = new ToolStripMenuItem();
            editProfileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)user).BeginInit();
            ((System.ComponentModel.ISupportInitialize)notification).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chat).BeginInit();
            contextMenuStrip1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 826);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(0, 811);
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
            report.Location = new Point(24, 377);
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
            project.Location = new Point(24, 317);
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
            task.Location = new Point(24, 257);
            task.Margin = new Padding(2);
            task.Name = "task";
            task.Size = new Size(210, 42);
            task.TabIndex = 2;
            task.Text = "Task Management";
            task.UseVisualStyleBackColor = false;
            task.Click += task_Click;
            // 
            // profile
            // 
            profile.BackColor = Color.DarkMagenta;
            profile.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            profile.ForeColor = SystemColors.Control;
            profile.Location = new Point(24, 199);
            profile.Margin = new Padding(2);
            profile.Name = "profile";
            profile.Size = new Size(210, 42);
            profile.TabIndex = 1;
            profile.Text = "Profile Management";
            profile.UseVisualStyleBackColor = false;
            profile.Click += profile_Click;
            // 
            // user
            // 
            user.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            user.Image = Properties.Resources.user;
            user.Location = new Point(1145, 2);
            user.Margin = new Padding(2);
            user.Name = "user";
            user.Size = new Size(55, 53);
            user.SizeMode = PictureBoxSizeMode.StretchImage;
            user.TabIndex = 1;
            user.TabStop = false;
            user.Click += user_Click;
            // 
            // notification
            // 
            notification.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            notification.Image = Properties.Resources.notification;
            notification.Location = new Point(1083, 2);
            notification.Margin = new Padding(2);
            notification.Name = "notification";
            notification.Size = new Size(58, 53);
            notification.SizeMode = PictureBoxSizeMode.StretchImage;
            notification.TabIndex = 2;
            notification.TabStop = false;
            notification.Click += notification_Click;
            // 
            // chat
            // 
            chat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chat.Image = Properties.Resources.chat;
            chat.Location = new Point(1022, 2);
            chat.Margin = new Padding(2);
            chat.Name = "chat";
            chat.Size = new Size(57, 53);
            chat.SizeMode = PictureBoxSizeMode.StretchImage;
            chat.TabIndex = 3;
            chat.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lavender;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(2, 2);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1198, 760);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { addProjectToolStripMenuItem, editProfileToolStripMenuItem, logoutToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(137, 70);
            // 
            // addProjectToolStripMenuItem
            // 
            addProjectToolStripMenuItem.Name = "addProjectToolStripMenuItem";
            addProjectToolStripMenuItem.Size = new Size(136, 22);
            addProjectToolStripMenuItem.Text = "Add Project";
            addProjectToolStripMenuItem.Click += addProjectToolStripMenuItem_Click;
            // 
            // editProfileToolStripMenuItem
            // 
            editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            editProfileToolStripMenuItem.Size = new Size(136, 22);
            editProfileToolStripMenuItem.Text = "Edit Profile";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(136, 22);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click_1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(user);
            flowLayoutPanel1.Controls.Add(notification);
            flowLayoutPanel1.Controls.Add(chat);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(267, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1202, 62);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(267, 62);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1202, 764);
            tableLayoutPanel1.TabIndex = 6;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1469, 826);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Admin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)user).EndInit();
            ((System.ComponentModel.ISupportInitialize)notification).EndInit();
            ((System.ComponentModel.ISupportInitialize)chat).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button profile;
        private Button report;
        private Button project;
        private Button task;
        private PictureBox pictureBox1;
        private PictureBox user;
        private PictureBox notification;
        private PictureBox chat;
        private Panel panel2;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editProfileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem addProjectToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}