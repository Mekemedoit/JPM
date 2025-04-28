using System;
using System.Drawing;
using System.Windows.Forms;


namespace JPM_Dev
{
    public partial class chatForm : Form
    {
        private ListBox chatListBox;
        private TextBox messageTextBox;
        private Button sendButton;

        public chatForm()
        {
            InitializeComponents();

        }
        private void ChatForm_Load(object sender, EventArgs e)
        {
            // This runs when ChatForm loads.
        }


        private void InitializeComponents()
        {
            // Form settings
            this.Text = "Chat Form";
            this.Size = new Size(400, 350);
            this.StartPosition = FormStartPosition.CenterScreen;


            // Chat ListBox
            chatListBox = new ListBox()
            {
                Location = new Point(10, 10),
                Size = new Size(360, 250)
            };
            this.Controls.Add(chatListBox);

            // Message TextBox
            messageTextBox = new TextBox()
            {
                Location = new Point(10, 270),
                Size = new Size(260, 30)
            };
            this.Controls.Add(messageTextBox);
            messageTextBox.KeyDown += MessageTextBox_KeyDown;

            // Send Button
            sendButton = new Button()
            {
                Text = "Send",
                Location = new Point(280, 270),
                Size = new Size(90, 30)
            };
            sendButton.Click += SendButton_Click;

            this.Controls.Add(sendButton);
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            SendMessage();
        }
        private void MessageTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessage();
                e.SuppressKeyPress = true; // prevents "ding" sound on Enter
            }
        }

        private async void SendMessage()
        {
            string message = messageTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(message))
            {
                chatListBox.Items.Add("You: " + message);
                messageTextBox.Clear();

                // Fake thinking delay
                await Task.Delay(500); // 500 milliseconds = half a second

                // Bot reply
                string botReply = GenerateBotReply(message);
                chatListBox.Items.Add("Bot: " + botReply);
            }
        }

        private string GenerateBotReply(string userMessage)
        {
            userMessage = userMessage.ToLower();

            if (userMessage.Contains("hello"))
                return "Hi there!";
            else if (userMessage.Contains("how are you"))
                return "I'm just a bot, but I'm doing great!";
            else if (userMessage.Contains("bye"))
                return "Goodbye! Talk to you later.";
            else
                return "I'm not sure how to respond to that.";
        }

    }
}