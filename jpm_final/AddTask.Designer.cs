namespace JPM_Dev
{
    partial class AddTask
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
            title = new Label();
            namelbl = new Label();
            nameTxt = new TextBox();
            detslbl = new Label();
            detsTxt = new TextBox();
            deadline = new Label();
            deadlineTxt = new TextBox();
            assignedDatePick = new DateTimePicker();
            assignedLbl = new Label();
            assignedToTxt = new TextBox();
            priorityLbl = new Label();
            priorityTxt = new TextBox();
            saveBtn = new Button();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = SystemColors.Control;
            title.Location = new Point(316, 29);
            title.Name = "title";
            title.Size = new Size(129, 25);
            title.TabIndex = 0;
            title.Text = "Task Details";
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namelbl.ForeColor = SystemColors.Control;
            namelbl.Location = new Point(29, 98);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(114, 22);
            namelbl.TabIndex = 1;
            namelbl.Text = "Task Name:";
            // 
            // nameTxt
            // 
            nameTxt.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTxt.Location = new Point(200, 89);
            nameTxt.Name = "nameTxt";
            nameTxt.PlaceholderText = "Task Name";
            nameTxt.Size = new Size(477, 31);
            nameTxt.TabIndex = 2;
            nameTxt.TextChanged += nameTxt_TextChanged;
            // 
            // detslbl
            // 
            detslbl.AutoSize = true;
            detslbl.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            detslbl.ForeColor = SystemColors.Control;
            detslbl.Location = new Point(29, 155);
            detslbl.Name = "detslbl";
            detslbl.Size = new Size(117, 22);
            detslbl.TabIndex = 3;
            detslbl.Text = "Task Details:";
            // 
            // detsTxt
            // 
            detsTxt.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            detsTxt.Location = new Point(200, 146);
            detsTxt.Name = "detsTxt";
            detsTxt.Size = new Size(477, 31);
            detsTxt.TabIndex = 4;
            // 
            // deadline
            // 
            deadline.AutoSize = true;
            deadline.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deadline.ForeColor = SystemColors.Control;
            deadline.Location = new Point(29, 210);
            deadline.Name = "deadline";
            deadline.Size = new Size(97, 22);
            deadline.TabIndex = 5;
            deadline.Text = "Deadline:";
            // 
            // deadlineTxt
            // 
            deadlineTxt.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deadlineTxt.Location = new Point(200, 201);
            deadlineTxt.Name = "deadlineTxt";
            deadlineTxt.Size = new Size(361, 31);
            deadlineTxt.TabIndex = 6;
            // 
            // assignedDatePick
            // 
            assignedDatePick.CalendarFont = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            assignedDatePick.Location = new Point(534, 204);
            assignedDatePick.Name = "assignedDatePick";
            assignedDatePick.Size = new Size(21, 23);
            assignedDatePick.TabIndex = 7;
            // 
            // assignedLbl
            // 
            assignedLbl.AutoSize = true;
            assignedLbl.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            assignedLbl.ForeColor = SystemColors.Control;
            assignedLbl.Location = new Point(29, 271);
            assignedLbl.Name = "assignedLbl";
            assignedLbl.Size = new Size(121, 22);
            assignedLbl.TabIndex = 8;
            assignedLbl.Text = "Assigned to:";
            // 
            // assignedToTxt
            // 
            assignedToTxt.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            assignedToTxt.Location = new Point(200, 262);
            assignedToTxt.Name = "assignedToTxt";
            assignedToTxt.Size = new Size(361, 31);
            assignedToTxt.TabIndex = 9;
            // 
            // priorityLbl
            // 
            priorityLbl.AutoSize = true;
            priorityLbl.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priorityLbl.ForeColor = SystemColors.Control;
            priorityLbl.Location = new Point(29, 325);
            priorityLbl.Name = "priorityLbl";
            priorityLbl.Size = new Size(74, 22);
            priorityLbl.TabIndex = 10;
            priorityLbl.Text = "Priority:";
            // 
            // priorityTxt
            // 
            priorityTxt.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priorityTxt.Location = new Point(200, 316);
            priorityTxt.Name = "priorityTxt";
            priorityTxt.Size = new Size(361, 31);
            priorityTxt.TabIndex = 11;
            // 
            // saveBtn
            // 
            saveBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveBtn.Location = new Point(567, 385);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(202, 63);
            saveBtn.TabIndex = 12;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // AddTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkMagenta;
            ClientSize = new Size(823, 483);
            Controls.Add(saveBtn);
            Controls.Add(priorityTxt);
            Controls.Add(priorityLbl);
            Controls.Add(assignedToTxt);
            Controls.Add(assignedLbl);
            Controls.Add(assignedDatePick);
            Controls.Add(deadlineTxt);
            Controls.Add(deadline);
            Controls.Add(detsTxt);
            Controls.Add(detslbl);
            Controls.Add(nameTxt);
            Controls.Add(namelbl);
            Controls.Add(title);
            Name = "AddTask";
            Text = "AddTask";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Label namelbl;
        private TextBox nameTxt;
        private Label detslbl;
        private TextBox detsTxt;
        private Label deadline;
        private TextBox deadlineTxt;
        private DateTimePicker assignedDatePick;
        private Label assignedLbl;
        private TextBox assignedToTxt;
        private Label priorityLbl;
        private TextBox priorityTxt;
        private Button saveBtn;
    }
}