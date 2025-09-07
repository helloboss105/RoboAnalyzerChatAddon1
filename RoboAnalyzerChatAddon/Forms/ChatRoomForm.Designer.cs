namespace RoboAnalyzerChatAddon.Forms
{
    partial class ChatRoomForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnShareFile;
        private System.Windows.Forms.Label lblRoomCode;
        private System.Windows.Forms.Label lblUsers;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            rtbChat = new RichTextBox();
            lstUsers = new ListBox();
            txtMessage = new TextBox();
            btnSend = new Button();
            btnShareFile = new Button();
            lblRoomCode = new Label();
            lblUsers = new Label();
            SuspendLayout();
            // 
            // rtbChat
            // 
            rtbChat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbChat.BackColor = SystemColors.Window;
            rtbChat.Location = new Point(16, 54);
            rtbChat.Margin = new Padding(4, 5, 4, 5);
            rtbChat.Name = "rtbChat";
            rtbChat.ReadOnly = true;
            rtbChat.Size = new Size(633, 490);
            rtbChat.TabIndex = 1;
            rtbChat.Text = "";
            rtbChat.TextChanged += rtbChat_TextChanged;
            // 
            // lstUsers
            // 
            lstUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lstUsers.BackColor = SystemColors.Window;
            lstUsers.FormattingEnabled = true;
            lstUsers.Location = new Point(659, 82);
            lstUsers.Margin = new Padding(4, 5, 4, 5);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(159, 444);
            lstUsers.TabIndex = 3;
            // 
            // txtMessage
            // 
            txtMessage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMessage.Location = new Point(16, 562);
            txtMessage.Margin = new Padding(4, 5, 4, 5);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(465, 59);
            txtMessage.TabIndex = 4;
            txtMessage.Tag = "";
            txtMessage.TextChanged += txtMessage_TextChanged;
            txtMessage.KeyPress += txtMessage_KeyPress;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSend.Location = new Point(491, 562);
            btnSend.Margin = new Padding(4, 5, 4, 5);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(80, 62);
            btnSend.TabIndex = 5;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnShareFile
            // 
            btnShareFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnShareFile.Location = new Point(579, 562);
            btnShareFile.Margin = new Padding(4, 5, 4, 5);
            btnShareFile.Name = "btnShareFile";
            btnShareFile.Size = new Size(100, 62);
            btnShareFile.TabIndex = 6;
            btnShareFile.Text = "Share File";
            btnShareFile.UseVisualStyleBackColor = true;
            btnShareFile.Click += btnShareFile_Click;
            // 
            // lblRoomCode
            // 
            lblRoomCode.AutoSize = true;
            lblRoomCode.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblRoomCode.Location = new Point(16, 14);
            lblRoomCode.Margin = new Padding(4, 0, 4, 0);
            lblRoomCode.Name = "lblRoomCode";
            lblRoomCode.Size = new Size(112, 20);
            lblRoomCode.TabIndex = 0;
            lblRoomCode.Text = "Room Code:";
            // 
            // lblUsers
            // 
            lblUsers.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsers.AutoSize = true;
            lblUsers.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblUsers.Location = new Point(659, 54);
            lblUsers.Margin = new Padding(4, 0, 4, 0);
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(58, 18);
            lblUsers.TabIndex = 2;
            lblUsers.Text = "Users:";
            // 
            // ChatRoomForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 642);
            Controls.Add(btnShareFile);
            Controls.Add(btnSend);
            Controls.Add(txtMessage);
            Controls.Add(lstUsers);
            Controls.Add(lblUsers);
            Controls.Add(rtbChat);
            Controls.Add(lblRoomCode);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(794, 590);
            Name = "ChatRoomForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chat Room";
            Load += ChatRoomForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}