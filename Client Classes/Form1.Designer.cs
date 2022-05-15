namespace Client_App
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.messageBox = new System.Windows.Forms.TextBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.ConnectionLabel = new System.Windows.Forms.Label();
            this.MessagesListView = new System.Windows.Forms.ListView();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.onlineUsersLV = new System.Windows.Forms.ListView();
            this.GroupChatTitle = new System.Windows.Forms.Label();
            this.OnlineUsersTitle = new System.Windows.Forms.Label();
            this.usernamePanel = new System.Windows.Forms.Panel();
            this.usernamePic = new System.Windows.Forms.PictureBox();
            this.usernameLinePnl = new System.Windows.Forms.Panel();
            this.passwordLinePnl = new System.Windows.Forms.Panel();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sendMessagePnl = new System.Windows.Forms.Panel();
            this.boardTableLayoutPnl = new System.Windows.Forms.TableLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.welcomeHaveFunLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.newGameBtn = new System.Windows.Forms.Button();
            this.usernamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePic)).BeginInit();
            this.passwordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sendMessagePnl.SuspendLayout();
            this.boardTableLayoutPnl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageBox
            // 
            this.messageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.messageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageBox.Enabled = false;
            this.messageBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.messageBox.Location = new System.Drawing.Point(1029, 700);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(421, 41);
            this.messageBox.TabIndex = 0;
            this.messageBox.Visible = false;
            this.messageBox.TextChanged += new System.EventHandler(this.messageBox_TextChanged);
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.sendMessageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sendMessageButton.BackgroundImage")));
            this.sendMessageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendMessageButton.Enabled = false;
            this.sendMessageButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.sendMessageButton.FlatAppearance.BorderSize = 0;
            this.sendMessageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sendMessageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sendMessageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendMessageButton.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendMessageButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sendMessageButton.Location = new System.Drawing.Point(15, 10);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(28, 23);
            this.sendMessageButton.TabIndex = 1;
            this.sendMessageButton.UseVisualStyleBackColor = false;
            this.sendMessageButton.Click += new System.EventHandler(this.button1_Click);
            this.sendMessageButton.MouseHover += new System.EventHandler(this.sendMessageButton_MouseHover);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LoginBtn.Location = new System.Drawing.Point(32, 257);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(128, 38);
            this.LoginBtn.TabIndex = 12;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.SignUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpBtn.FlatAppearance.BorderSize = 0;
            this.SignUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBtn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.SignUpBtn.Location = new System.Drawing.Point(166, 257);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(128, 38);
            this.SignUpBtn.TabIndex = 11;
            this.SignUpBtn.Text = "+ Sign Up";
            this.SignUpBtn.UseVisualStyleBackColor = false;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // ConnectionLabel
            // 
            this.ConnectionLabel.AutoSize = true;
            this.ConnectionLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.ConnectionLabel.Location = new System.Drawing.Point(99, 716);
            this.ConnectionLabel.Name = "ConnectionLabel";
            this.ConnectionLabel.Size = new System.Drawing.Size(123, 17);
            this.ConnectionLabel.TabIndex = 24;
            this.ConnectionLabel.Text = "Not Connected";
            this.ConnectionLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // MessagesListView
            // 
            this.MessagesListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.MessagesListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessagesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessagesListView.HideSelection = false;
            this.MessagesListView.Location = new System.Drawing.Point(1029, 446);
            this.MessagesListView.Name = "MessagesListView";
            this.MessagesListView.Size = new System.Drawing.Size(421, 248);
            this.MessagesListView.TabIndex = 26;
            this.MessagesListView.UseCompatibleStateImageBehavior = false;
            this.MessagesListView.View = System.Windows.Forms.View.List;
            this.MessagesListView.Visible = false;
            // 
            // UsernameTB
            // 
            this.UsernameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.UsernameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTB.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.UsernameTB.Location = new System.Drawing.Point(37, 7);
            this.UsernameTB.Margin = new System.Windows.Forms.Padding(5);
            this.UsernameTB.MaxLength = 16;
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(262, 21);
            this.UsernameTB.TabIndex = 27;
            this.UsernameTB.Text = "Username...";
            this.UsernameTB.TextChanged += new System.EventHandler(this.UsernameTB_TextChanged);
            this.UsernameTB.Enter += new System.EventHandler(this.UsernameTB_Enter);
            this.UsernameTB.Leave += new System.EventHandler(this.UsernameTB_Leave);
            // 
            // PasswordTB
            // 
            this.PasswordTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.PasswordTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.PasswordTB.HideSelection = false;
            this.PasswordTB.Location = new System.Drawing.Point(37, 8);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(261, 21);
            this.PasswordTB.TabIndex = 28;
            this.PasswordTB.Text = "Password";
            this.PasswordTB.UseSystemPasswordChar = true;
            this.PasswordTB.Enter += new System.EventHandler(this.PasswordTB_Enter);
            this.PasswordTB.Leave += new System.EventHandler(this.PasswordTB_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(73, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 60);
            this.button1.TabIndex = 29;
            this.button1.Text = "Settings";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 44);
            this.label1.TabIndex = 30;
            this.label1.Text = "Log In!";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // onlineUsersLV
            // 
            this.onlineUsersLV.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.onlineUsersLV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.onlineUsersLV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.onlineUsersLV.HideSelection = false;
            this.onlineUsersLV.Location = new System.Drawing.Point(1029, 178);
            this.onlineUsersLV.MultiSelect = false;
            this.onlineUsersLV.Name = "onlineUsersLV";
            this.onlineUsersLV.Size = new System.Drawing.Size(262, 224);
            this.onlineUsersLV.TabIndex = 31;
            this.onlineUsersLV.UseCompatibleStateImageBehavior = false;
            this.onlineUsersLV.View = System.Windows.Forms.View.List;
            this.onlineUsersLV.Visible = false;
            this.onlineUsersLV.SelectedIndexChanged += new System.EventHandler(this.onlineUsersLV_SelectedIndexChanged_1);
            // 
            // GroupChatTitle
            // 
            this.GroupChatTitle.AutoSize = true;
            this.GroupChatTitle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupChatTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GroupChatTitle.Location = new System.Drawing.Point(1025, 416);
            this.GroupChatTitle.Name = "GroupChatTitle";
            this.GroupChatTitle.Size = new System.Drawing.Size(116, 20);
            this.GroupChatTitle.TabIndex = 32;
            this.GroupChatTitle.Text = "Group Chat";
            this.GroupChatTitle.Visible = false;
            // 
            // OnlineUsersTitle
            // 
            this.OnlineUsersTitle.AutoSize = true;
            this.OnlineUsersTitle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnlineUsersTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OnlineUsersTitle.Location = new System.Drawing.Point(1025, 149);
            this.OnlineUsersTitle.Name = "OnlineUsersTitle";
            this.OnlineUsersTitle.Size = new System.Drawing.Size(129, 20);
            this.OnlineUsersTitle.TabIndex = 33;
            this.OnlineUsersTitle.Text = "Online Users";
            this.OnlineUsersTitle.Visible = false;
            // 
            // usernamePanel
            // 
            this.usernamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.usernamePanel.Controls.Add(this.UsernameTB);
            this.usernamePanel.Controls.Add(this.usernamePic);
            this.usernamePanel.Location = new System.Drawing.Point(32, 115);
            this.usernamePanel.Name = "usernamePanel";
            this.usernamePanel.Size = new System.Drawing.Size(261, 35);
            this.usernamePanel.TabIndex = 35;
            // 
            // usernamePic
            // 
            this.usernamePic.Image = ((System.Drawing.Image)(resources.GetObject("usernamePic.Image")));
            this.usernamePic.InitialImage = ((System.Drawing.Image)(resources.GetObject("usernamePic.InitialImage")));
            this.usernamePic.Location = new System.Drawing.Point(9, 7);
            this.usernamePic.Name = "usernamePic";
            this.usernamePic.Size = new System.Drawing.Size(20, 21);
            this.usernamePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.usernamePic.TabIndex = 28;
            this.usernamePic.TabStop = false;
            // 
            // usernameLinePnl
            // 
            this.usernameLinePnl.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.usernameLinePnl.Location = new System.Drawing.Point(32, 150);
            this.usernameLinePnl.Name = "usernameLinePnl";
            this.usernameLinePnl.Size = new System.Drawing.Size(261, 3);
            this.usernameLinePnl.TabIndex = 35;
            this.usernameLinePnl.Paint += new System.Windows.Forms.PaintEventHandler(this.usernameLinePnl_Paint);
            // 
            // passwordLinePnl
            // 
            this.passwordLinePnl.BackColor = System.Drawing.Color.DarkGray;
            this.passwordLinePnl.Location = new System.Drawing.Point(32, 219);
            this.passwordLinePnl.Name = "passwordLinePnl";
            this.passwordLinePnl.Size = new System.Drawing.Size(261, 3);
            this.passwordLinePnl.TabIndex = 36;
            // 
            // passwordPanel
            // 
            this.passwordPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.passwordPanel.Controls.Add(this.pictureBox1);
            this.passwordPanel.Controls.Add(this.PasswordTB);
            this.passwordPanel.Location = new System.Drawing.Point(32, 184);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(261, 35);
            this.passwordPanel.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // sendMessagePnl
            // 
            this.sendMessagePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.sendMessagePnl.Controls.Add(this.sendMessageButton);
            this.sendMessagePnl.Location = new System.Drawing.Point(1395, 700);
            this.sendMessagePnl.Name = "sendMessagePnl";
            this.sendMessagePnl.Size = new System.Drawing.Size(55, 41);
            this.sendMessagePnl.TabIndex = 39;
            this.sendMessagePnl.Visible = false;
            // 
            // boardTableLayoutPnl
            // 
            this.boardTableLayoutPnl.BackColor = System.Drawing.Color.Coral;
            this.boardTableLayoutPnl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.boardTableLayoutPnl.ColumnCount = 4;
            this.boardTableLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.boardTableLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.boardTableLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.boardTableLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.boardTableLayoutPnl.Controls.Add(this.label17, 3, 3);
            this.boardTableLayoutPnl.Controls.Add(this.label16, 2, 3);
            this.boardTableLayoutPnl.Controls.Add(this.label15, 1, 3);
            this.boardTableLayoutPnl.Controls.Add(this.label14, 0, 3);
            this.boardTableLayoutPnl.Controls.Add(this.label13, 3, 2);
            this.boardTableLayoutPnl.Controls.Add(this.label12, 2, 2);
            this.boardTableLayoutPnl.Controls.Add(this.label11, 1, 2);
            this.boardTableLayoutPnl.Controls.Add(this.label10, 0, 2);
            this.boardTableLayoutPnl.Controls.Add(this.label9, 3, 1);
            this.boardTableLayoutPnl.Controls.Add(this.label8, 2, 1);
            this.boardTableLayoutPnl.Controls.Add(this.label7, 1, 1);
            this.boardTableLayoutPnl.Controls.Add(this.label6, 0, 1);
            this.boardTableLayoutPnl.Controls.Add(this.label5, 3, 0);
            this.boardTableLayoutPnl.Controls.Add(this.label4, 2, 0);
            this.boardTableLayoutPnl.Controls.Add(this.label3, 1, 0);
            this.boardTableLayoutPnl.Controls.Add(this.label2, 0, 0);
            this.boardTableLayoutPnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boardTableLayoutPnl.Location = new System.Drawing.Point(369, 150);
            this.boardTableLayoutPnl.Name = "boardTableLayoutPnl";
            this.boardTableLayoutPnl.RowCount = 4;
            this.boardTableLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.boardTableLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.boardTableLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.boardTableLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.boardTableLayoutPnl.Size = new System.Drawing.Size(632, 591);
            this.boardTableLayoutPnl.TabIndex = 40;
            this.boardTableLayoutPnl.Visible = false;
            // 
            // label17
            // 
            this.label17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Webdings", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label17.ForeColor = System.Drawing.Color.Coral;
            this.label17.Location = new System.Drawing.Point(476, 443);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(151, 146);
            this.label17.TabIndex = 15;
            this.label17.Text = "p";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label17.Click += new System.EventHandler(this.boardLabel_Click);
            this.label17.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // label16
            // 
            this.label16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Webdings", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label16.ForeColor = System.Drawing.Color.Coral;
            this.label16.Location = new System.Drawing.Point(319, 443);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(149, 146);
            this.label16.TabIndex = 14;
            this.label16.Text = "p";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Click += new System.EventHandler(this.boardLabel_Click);
            this.label16.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // label15
            // 
            this.label15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Webdings", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label15.ForeColor = System.Drawing.Color.Coral;
            this.label15.Location = new System.Drawing.Point(162, 443);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 146);
            this.label15.TabIndex = 13;
            this.label15.Text = "p";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Click += new System.EventHandler(this.boardLabel_Click);
            this.label15.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // label14
            // 
            this.label14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Webdings", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label14.ForeColor = System.Drawing.Color.Coral;
            this.label14.Location = new System.Drawing.Point(5, 443);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 146);
            this.label14.TabIndex = 12;
            this.label14.Text = "p";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Click += new System.EventHandler(this.boardLabel_Click);
            this.label14.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // label13
            // 
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Webdings", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label13.ForeColor = System.Drawing.Color.Coral;
            this.label13.Location = new System.Drawing.Point(476, 296);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 145);
            this.label13.TabIndex = 11;
            this.label13.Text = "p";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Click += new System.EventHandler(this.boardLabel_Click);
            this.label13.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // label12
            // 
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Webdings", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label12.ForeColor = System.Drawing.Color.Coral;
            this.label12.Location = new System.Drawing.Point(319, 296);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 145);
            this.label12.TabIndex = 10;
            this.label12.Text = "p";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.boardLabel_Click);
            this.label12.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // label11
            // 
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Webdings", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label11.ForeColor = System.Drawing.Color.Coral;
            this.label11.Location = new System.Drawing.Point(162, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 145);
            this.label11.TabIndex = 9;
            this.label11.Text = "p";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.boardLabel_Click);
            this.label11.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // label10
            // 
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Webdings", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label10.ForeColor = System.Drawing.Color.Coral;
            this.label10.Location = new System.Drawing.Point(5, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 145);
            this.label10.TabIndex = 8;
            this.label10.Text = "p";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.boardLabel_Click);
            this.label10.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // label9
            // 
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Webdings", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label9.ForeColor = System.Drawing.Color.Coral;
            this.label9.Location = new System.Drawing.Point(476, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 145);
            this.label9.TabIndex = 7;
            this.label9.Text = "p";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.boardLabel_Click);
            this.label9.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // label8
            // 
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Webdings", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label8.ForeColor = System.Drawing.Color.Coral;
            this.label8.Location = new System.Drawing.Point(319, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 145);
            this.label8.TabIndex = 6;
            this.label8.Text = "p";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.boardLabel_Click);
            this.label8.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // label7
            // 
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Webdings", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label7.ForeColor = System.Drawing.Color.Coral;
            this.label7.Location = new System.Drawing.Point(162, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 145);
            this.label7.TabIndex = 5;
            this.label7.Text = "p";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.boardLabel_Click);
            this.label7.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // label6
            // 
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Webdings", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label6.ForeColor = System.Drawing.Color.Coral;
            this.label6.Location = new System.Drawing.Point(5, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 145);
            this.label6.TabIndex = 4;
            this.label6.Text = "p";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.boardLabel_Click);
            this.label6.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Webdings", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(476, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 145);
            this.label5.TabIndex = 3;
            this.label5.Text = "p";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.boardLabel_Click);
            this.label5.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // label4
            // 
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Webdings", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(319, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 145);
            this.label4.TabIndex = 2;
            this.label4.Text = "p";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.boardLabel_Click);
            this.label4.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Webdings", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(162, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 145);
            this.label3.TabIndex = 1;
            this.label3.Text = "p";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.boardLabel_Click);
            this.label3.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Webdings", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(5, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 145);
            this.label2.TabIndex = 0;
            this.label2.Text = "p";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.boardLabel_Click);
            this.label2.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1099, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 28);
            this.button2.TabIndex = 41;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.SignUpBtn);
            this.panel2.Controls.Add(this.LoginBtn);
            this.panel2.Controls.Add(this.passwordLinePnl);
            this.panel2.Controls.Add(this.usernamePanel);
            this.panel2.Controls.Add(this.passwordPanel);
            this.panel2.Controls.Add(this.usernameLinePnl);
            this.panel2.Controls.Add(this.ConnectionLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 764);
            this.panel2.TabIndex = 42;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(28, 716);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 17);
            this.label19.TabIndex = 41;
            this.label19.Text = "Server:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(0, 602);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(338, 80);
            this.panel3.TabIndex = 40;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(28, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 44);
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel8.Controls.Add(this.pictureBox2);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(338, 80);
            this.panel8.TabIndex = 39;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(28, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 44);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.panel7.Controls.Add(this.button2);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Location = new System.Drawing.Point(336, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1147, 80);
            this.panel7.TabIndex = 43;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            this.panel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(37, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(524, 44);
            this.label18.TabIndex = 38;
            this.label18.Text = "Welcome to my Memory Game!";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // welcomeHaveFunLbl
            // 
            this.welcomeHaveFunLbl.AutoSize = true;
            this.welcomeHaveFunLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeHaveFunLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.welcomeHaveFunLbl.Location = new System.Drawing.Point(372, 96);
            this.welcomeHaveFunLbl.Name = "welcomeHaveFunLbl";
            this.welcomeHaveFunLbl.Size = new System.Drawing.Size(546, 44);
            this.welcomeHaveFunLbl.TabIndex = 44;
            this.welcomeHaveFunLbl.Text = "Welcome! You are not logged in!";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // newGameBtn
            // 
            this.newGameBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.newGameBtn.FlatAppearance.BorderSize = 0;
            this.newGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newGameBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newGameBtn.Location = new System.Drawing.Point(1313, 362);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(137, 40);
            this.newGameBtn.TabIndex = 45;
            this.newGameBtn.Text = "New Game";
            this.newGameBtn.UseVisualStyleBackColor = false;
            this.newGameBtn.Visible = false;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1478, 764);
            this.Controls.Add(this.newGameBtn);
            this.Controls.Add(this.sendMessagePnl);
            this.Controls.Add(this.welcomeHaveFunLbl);
            this.Controls.Add(this.boardTableLayoutPnl);
            this.Controls.Add(this.OnlineUsersTitle);
            this.Controls.Add(this.GroupChatTitle);
            this.Controls.Add(this.onlineUsersLV);
            this.Controls.Add(this.MessagesListView);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.usernamePanel.ResumeLayout(false);
            this.usernamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePic)).EndInit();
            this.passwordPanel.ResumeLayout(false);
            this.passwordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sendMessagePnl.ResumeLayout(false);
            this.boardTableLayoutPnl.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.Label ConnectionLabel;
        private System.Windows.Forms.ListView MessagesListView;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView onlineUsersLV;
        private System.Windows.Forms.Label GroupChatTitle;
        private System.Windows.Forms.Label OnlineUsersTitle;
        private System.Windows.Forms.Panel usernamePanel;
        private System.Windows.Forms.Panel usernameLinePnl;
        private System.Windows.Forms.Panel passwordLinePnl;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.PictureBox usernamePic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel sendMessagePnl;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.TableLayoutPanel boardTableLayoutPnl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label welcomeHaveFunLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button newGameBtn;
    }
}

