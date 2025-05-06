using System;
using System.Windows.Forms;

namespace JPM_Dev
{
    public partial class TaskSubmissionForm : Form
    {
        private Label taskLabel;
        private TextBox taskTextBox;
        private Button saveButton;
        private string taskId;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private bool isEditorMode;

        public string UpdatedTask { get; private set; } // To return updated text

        public TaskSubmissionForm(string taskId, bool isEditorMode)
        {

            this.taskId = taskId;
            this.isEditorMode = isEditorMode;

            BuildUI();
        }

        private void BuildUI()
        {
            this.Text = isEditorMode ? "Edit Task" : "New Task";
            this.Size = new System.Drawing.Size(300, 200);
            this.StartPosition = FormStartPosition.CenterParent;

            taskLabel = new Label
            {
                Text = isEditorMode ? "Edit the task:" : "Enter your task:",
                Location = new System.Drawing.Point(10, 20),
                AutoSize = true
            };
            taskTextBox = new TextBox
            {
                Location = new System.Drawing.Point(10, 50),
                Width = 250
            };
            // Save button
            Button saveButton = new Button();
            saveButton.Text = "Save";
            saveButton.Size = new Size(80, 30);
            saveButton.Location = new Point(90, 120);
            saveButton.Click += (s, e) => SaveTask();

            // Cancel button
            Button cancelButton = new Button();
            cancelButton.Text = "Cancel";
            cancelButton.Size = new Size(80, 30);
            cancelButton.Location = new Point(180, 120);
            cancelButton.Click += (s, e) => this.Close(); // <-- Just closes the form

            // Add controls to the form
            this.Controls.Add(taskLabel);
            this.Controls.Add(taskTextBox);
            this.Controls.Add(saveButton);
            this.Controls.Add(cancelButton);



        }

        public void SetInitialTaskText(string text)
        {
            taskTextBox.Text = text;
        }


        private void SaveTask()
        {
            if (string.IsNullOrEmpty(taskTextBox.Text))
            {
                MessageBox.Show("Task cannot be empty.");
                return;
            }
            UpdatedTask = taskTextBox.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 70);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 0;
            label1.Text = "System ID";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightYellow;
            textBox1.Location = new Point(53, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(473, 31);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 147);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 2;
            label2.Text = "Reference";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(53, 175);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(473, 31);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 235);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 4;
            label3.Text = "Name";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(53, 263);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(473, 31);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 323);
            label4.Name = "label4";
            label4.Size = new Size(44, 25);
            label4.TabIndex = 6;
            label4.Text = "Title";
            label4.Click += label4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(53, 351);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(473, 31);
            textBox4.TabIndex = 7;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 408);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 8;
            label5.Text = "Type";
            label5.Click += label5_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(53, 436);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(473, 31);
            textBox5.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 493);
            label6.Name = "label6";
            label6.Size = new Size(47, 25);
            label6.TabIndex = 10;
            label6.Text = "Tags";
            label6.Click += label6_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(53, 521);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(473, 31);
            textBox6.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(53, 635);
            label7.Name = "label7";
            label7.Size = new Size(102, 25);
            label7.TabIndex = 12;
            label7.Text = "Description";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(53, 677);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(773, 104);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(698, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 314);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(1063, 776);
            button1.Name = "button1";
            button1.Size = new Size(119, 49);
            button1.TabIndex = 15;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(713, 136);
            button2.Name = "button2";
            button2.Size = new Size(354, 281);
            button2.TabIndex = 16;
            button2.Text = "Choose Image";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TaskSubmissionForm
            // 
            ClientSize = new Size(1215, 846);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox1);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "TaskSubmissionForm";
            Text = "Concept Bio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            UpdatedTask = taskTextBox.Text.Trim();
            if (string.IsNullOrEmpty(UpdatedTask))
            {
                MessageBox.Show("Task cannot be empty.");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
