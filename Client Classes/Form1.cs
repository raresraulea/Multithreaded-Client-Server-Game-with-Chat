using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using ChatAppClasses;

namespace Client_App
{
    public partial class Form1 : Form
    {
        
        public Board gameBoard;
        public Dictionary<string, PrivateMessageForm> userForms = new Dictionary<string, PrivateMessageForm>();
        public Dictionary<string, bool> isPMFormOpen = new Dictionary<string, bool>();
        public connectionToServer connection;
        AdminForm adminApp = new AdminForm();
        public User myUser = new User();
        bool startedConnection = false;
        bool loggedIn = false;
        public int clientNumber;
        public static int movesCount = 0;
        List<string> icons;
        public int portFromSettings = 1302;
        public string IPFromSettings;


        delegate void UserUpdateCallback(string text);
        delegate void MessageUpdateCallback(string text);

        public delegate void LoginUI();
        public LoginUI LoginUIDelegate;

        public delegate void LoginPopup();
        public LoginPopup LoginPopupDelegate;

        public delegate void AdminUI();
        public AdminUI AdminUIDelegate;

        public delegate void WelcomeAdmin();
        public WelcomeAdmin WelcomeAdminPopupDelegate;

        public delegate void WrongCredentialsPopup();
        public WrongCredentialsPopup WrongCredentialsPopupDelegate;

        public delegate void ClearUsersListView();
        public ClearUsersListView ClearUsersListViewDelegate;

        public delegate void DoLogout();
        public DoLogout DoLogoutDelegate;

        public delegate void LogoutPopup();
        public LogoutPopup LogoutPopupDelegate;

        public delegate void UpdateMessages();
        public UpdateMessages UpdateMessagesDelegate;


        Thread loginThread;

        public Form1()
        {
            InitializeComponent();
            IPAddress hostIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList[0];
            User clientUser = new User();
            clientUser.IP = hostIP.ToString();
            Init();

        }

        private void Init()
        {
            LoginUIDelegate = new LoginUI(ActivateUserInterface_login);
            LoginPopupDelegate = new LoginPopup(showLoginPopup);
            AdminUIDelegate = new AdminUI(ActivateAdminInterface_login);
            WelcomeAdminPopupDelegate = new WelcomeAdmin(showWelcomeAdminPopup);
            WrongCredentialsPopupDelegate = new WrongCredentialsPopup(showWrongCredentialsPopup);
            ClearUsersListViewDelegate = new ClearUsersListView(clearUsersListView);
            DoLogoutDelegate = new DoLogout(doLogout);
            LogoutPopupDelegate = new LogoutPopup(showLogoutPopup);
            UpdateMessagesDelegate = new UpdateMessages(updateMessageListView);
            gameBoard = new Board(this);
            adminApp.setForm(this);
        }

        private void updateMessageListView()
        {
            throw new NotImplementedException();
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            updateUI_disconnect();
        }

        private void updateUI_disconnect()
        {
            this.LoginBtn.Enabled = false;
            LoginBtn.BackColor = Constants.Inactive;
            this.SignUpBtn.Enabled = false;
            this.SignUpBtn.BackColor = Constants.Inactive;
            this.ConnectionLabel.Text = "Not Connected";
            this.ConnectionLabel.ForeColor = Color.Red;
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (!startedConnection)
            {
                startedConnection = true;
                connection = new connectionToServer();
                connection.client = new TcpClient(Dns.GetHostName(), connection.port);
                connection.networkStream = connection.client.GetStream();
            }
            BinaryFormatter formatter = new BinaryFormatter();

            ChatAppClasses.Message messageToSend = new ChatAppClasses.Message();
            messageToSend.MessageText = "Sign Up Request";
            messageToSend.Type = "SignUp";
            messageToSend.username = UsernameTB.Text.ToString();
            messageToSend.password = PasswordTB.Text.ToString();

            formatter.Serialize(connection.networkStream, messageToSend);
            connection.networkStream.Flush();

            ChatAppClasses.Message messageFromServer;
            messageFromServer = (ChatAppClasses.Message)formatter.Deserialize(connection.networkStream);
            if (messageFromServer.MessageText != "Username already taken")
                showSignUpPopUp();
            else
                showRetrySignUpPopup();

            startedConnection = false;

        }

        private void showRetrySignUpPopup()
        {
            Popup popup = new Popup();
            popup.BackColor = Constants.LogoutBtnActive;
            popup.message.Text = "Username already taken. Retry!";
            popup.Show();
        }

        private static void showSignUpPopUp()
        {
            Popup popup = new Popup();
            popup.BackColor = Constants.SignUpPopupColor;
            popup.message.Text = "Signed Up!";
            popup.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!startedConnection)
                {
                    startedConnection = true;
                    connection = new connectionToServer();
                    connection.client = new TcpClient(Dns.GetHostName(), connection.port);
                    connection.networkStream = connection.client.GetStream();
                }
                BinaryFormatter formatter = new BinaryFormatter();

                ChatAppClasses.Message messageToSend = new ChatAppClasses.Message();
                messageToSend.MessageText = this.messageBox.Text;
                messageToSend.Type = "Message";
                messageToSend.username = myUser.username;
                messageToSend.Sender = myUser.username;
                formatter.Serialize(connection.networkStream, messageToSend);
                this.messageBox.Text = "";

            }
            catch (Exception exc)
            {

                Console.WriteLine("Failed to send..." + exc.Message);
            }
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            loggedIn = true;
            loginThread = new Thread(() => listenLoggedIn());
            myUser.username = this.UsernameTB.Text;
            myUser.password = this.PasswordTB.Text;

            if (this.LoginBtn.Text == "Login")
            {
                if (!startedConnection)
                {
                    startedConnection = true;
                    connection = new connectionToServer();
                    connection.client = new TcpClient(Dns.GetHostName(), connection.port);
                    connection.networkStream = connection.client.GetStream();
                }

                ChatAppClasses.Message messageToSend = new ChatAppClasses.Message();
                generateLoginMessage(messageToSend);

                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(connection.networkStream, messageToSend);
                connection.networkStream.Flush();

                loginThread.Start();
                return;
            }
            else if (LoginBtn.Text == "Logout")
            {
                loggedIn = false;
                adminApp.Visible = false;

                ChatAppClasses.Message messageToSend = new ChatAppClasses.Message();
                messageToSend.Type = "Logout";
                messageToSend.username = myUser.username;
                messageToSend.password = myUser.password;
                IFormatter formatter = new BinaryFormatter();

                formatter.Serialize(connection.networkStream, messageToSend);
                connection.networkStream.Flush();

            }
            else
            {
                LoginBtn.Text = "Unknown ERROR";
            }

        }

        public void updatePM(PrivateMessageForm form, string text)
        {
            form.MessagesListView.Items.Add(text);
        }
        public void listenLoggedIn()
        {
            Console.WriteLine("Listen Thread started: Logged In");
            BinaryFormatter formatter = new BinaryFormatter();

            while (loggedIn)
            {
                ChatAppClasses.Message messageFromServer;
                messageFromServer = (ChatAppClasses.Message)formatter.Deserialize(connection.networkStream);

                MyThreadClass myThreadClassObject = new MyThreadClass(this);
                string responseFromServer = messageFromServer.MessageText;

                switch (responseFromServer)
                {
                    case Constants.UserLoginSuccessResponse:
                        this.clientNumber = messageFromServer.clientNumber;
                        myThreadClassObject.Run("LoginUI");
                        myThreadClassObject.Run("LoginPopup");
                        break;
                    case Constants.WelcomeAdminResponse:
                        myThreadClassObject.Run("LoginUI");
                        myThreadClassObject.Run("AdminUI");
                        myThreadClassObject.Run("WelcomeAdminPopup");
                        break;
                    case Constants.WrongCredentialsResponse:
                        myThreadClassObject.Run("WrongCredentialsPopup");
                        loggedIn = false;
                        startedConnection = false;
                        break;
                    case "Logged Out!":
                        myThreadClassObject.Run("DoLogout");
                        myThreadClassObject.Run("ShowLogoutPopup");
                        loggedIn = false;
                        break;


                }
                switch (messageFromServer.Type)
                {
                    case "List":
                        foreach (var user in messageFromServer.onlineUser)
                        {
                            if (!userForms.ContainsKey(user))
                            {
                                PrivateMessageForm formToAdd = new PrivateMessageForm(this, user);
                                formToAdd.Name = user;
                                userForms.Add(user, formToAdd);
                                isPMFormOpen.Add(user, false);
                                Console.WriteLine("added form for " + user);
                            }
                        }
                        updateOnlineUsers(messageFromServer);
                        break;
                    case "broadcastMessage":
                        UpdateBroadcastedMessage(messageFromServer);
                        break;
                    case "Winner":
                        this.Invoke((Action)(() => showNewGameButton()));
                        WinnerForm winform = new WinnerForm();
                        winform.MainLabel.Text = messageFromServer.MessageText;
                        winform.ShowDialog();
                        break;
                    case "broadcastIcon":
                        movesCount++;
                        Console.WriteLine("Received from Server: " + messageFromServer.clickedIcon);
                        Console.WriteLine("Position from Server: " + messageFromServer.positionOnBoard);
                        for (int i = 0; i < boardTableLayoutPnl.Controls.Count; i++)
                            if (i == messageFromServer.positionOnBoard)
                                this.Invoke((Action)(() => showIconOnBoard(messageFromServer.iconColor, boardTableLayoutPnl.Controls[i])));
                        break;
                    case "redrawPositions":
                        for (int i = 0; i < boardTableLayoutPnl.Controls.Count; i++)
                        {
                            if (i == messageFromServer.firstPositionToRedraw) //paote fi rescris cu ||
                                this.Invoke((Action)(() => hideIconOnBoard(boardTableLayoutPnl.Controls[i])));
                            if (i == messageFromServer.secondPositionToRedraw)
                                this.Invoke((Action)(() => hideIconOnBoard(boardTableLayoutPnl.Controls[i])));
                        }

                        break;
                    case "PrivateMessage":
                        Console.WriteLine("PM received from " + messageFromServer.Sender);
                        PrivateMessageForm form1 = userForms[messageFromServer.Sender];
                        string textToBeAdded = messageFromServer.Sender + ": " + messageFromServer.MessageText;
                        Console.WriteLine(messageFromServer.Sender + ", form: " + form1.Name);
                        if (!IsFormOpen(form1))
                        {
                            Console.WriteLine("Nu e deschis!");

                            this.Invoke((Action)(() => updatePM(form1, textToBeAdded)));
                            this.Invoke((Action)(() => customShowForm(form1)));
                            isPMFormOpen[messageFromServer.Sender] = true;
                        }
                        else
                        {
                            Console.WriteLine("FORM deschis!");
                            this.Invoke((Action)(() => updatePM(form1, textToBeAdded)));
                        }
                        break;
                    case "shuffledIcons":
                        Console.WriteLine("Am primit lista! ");
                        for (int i = 0; i < boardTableLayoutPnl.Controls.Count; i++)
                            if (boardTableLayoutPnl.Controls[i] is Label)
                                this.Invoke((Action)(() => hideIconOnBoard(boardTableLayoutPnl.Controls[i])));

                        movesCount = 0;
                        this.Invoke((Action)(() => hideNewGameButton()));
                        icons = messageFromServer.shuffledIconsList;
                        gameBoard.icons = icons;
                        this.Invoke((Action)(() => UpdateBoard()));
                        break;
                }

            }
            Console.WriteLine("Listen Thread stopped: Logged Out");
            loginThread.Abort();
        }

        private void showNewGameButton()
        {
            this.newGameBtn.Visible = true;
        }
        private void hideNewGameButton()
        {
            this.newGameBtn.Visible = false;
        }

        private void hideIconOnBoard(Control control)
        {
            control.ForeColor = Color.Coral;
            control.BackColor = Color.Coral;
        }

        private void showIconOnBoard(Color color, Control control)
        {
            control.ForeColor = Color.White;
            control.BackColor = color;
        }

        private void UpdateBoard()
        {
            int next = 0;
            for (int i = 0; i < boardTableLayoutPnl.Controls.Count; i++)
                if (boardTableLayoutPnl.Controls[i] is Label)
                    boardTableLayoutPnl.Controls[i].Text =gameBoard.icons[next++];
        }

        private void customShowForm(PrivateMessageForm form1)
        {
            form1.Show();
        }

        public bool IsFormOpen(PrivateMessageForm myForm)
        {
            foreach (PrivateMessageForm form in Application.OpenForms.OfType<PrivateMessageForm>())
                if (form.Name == myForm.Name)
                    return true;
            return false;
        }

        private static void showWrongCredentialsPopup()
        {
            Popup popup = new Popup();
            popup.BackColor = Constants.WrongCredentialsPopupColor;
            popup.message.Text = "wrong Credentials!";
            popup.Show();
        }

        private void UpdateUsers(string user)
        {
            if (this.onlineUsersLV.InvokeRequired)
            {
                UserUpdateCallback userUpdate = new UserUpdateCallback(UpdateUsers);
                this.Invoke(userUpdate, new object[] { user });
            }
            else
                this.onlineUsersLV.Items.Add(user);
        }
        private void updateOnlineUsers(ChatAppClasses.Message messageFromServer)
        {
            if (messageFromServer.Type == "List")
            {
                MyThreadClass myThreadClassObject = new MyThreadClass(this);
                myThreadClassObject.Run("ClearUsersListView");
                foreach (var user in messageFromServer.onlineUser)
                    UpdateUsers(user);
            }
        }
        private void UpdateBroadcastedMessage(ChatAppClasses.Message messageFromServer)
        {
            if (messageFromServer.Type == "broadcastMessage")
            {
                MyThreadClass myThreadClassObject = new MyThreadClass(this);
                UpdateMessagesWithDelegate(messageFromServer.MessageText);
            }
        }
        private void UpdateMessagesWithDelegate(string message)
        {
            if (this.InvokeRequired)
            {
                MessageUpdateCallback messageUpdate = new MessageUpdateCallback(UpdateMessagesWithDelegate);
                this.Invoke(messageUpdate, new object[] { message });
            }
            else
                this.MessagesListView.Items.Add(message);
        }

        private void clearUsersListView()
        {
            this.onlineUsersLV.Clear();
        }

        private void doLogout()
        {
            LogoutActivations();
            LogoutDeactivations();
            startedConnection = false;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.BackColor = Constants.LoginBtnActive;
            this.UsernameTB.Text = String.Empty;
            this.PasswordTB.Text = String.Empty;
            this.ConnectionLabel.Text = "Disconnected";
            this.ConnectionLabel.ForeColor = Color.DarkRed;
            this.usernamePanel.Enabled = true;
            this.UsernameTB.Enabled = true;

        }
        private static void showLogoutPopup()
        {
            Popup popup = new Popup();
            popup.BackColor = Constants.LogoutPopupColor;
            popup.message.Text = "Logged Out!";
            popup.Show();
        }

        private static void showWelcomeAdminPopup()
        {
            Popup popup = new Popup();
            popup.BackColor = Constants.LoginPopupColor;
            popup.message.Text = "Welcome Admin!";
            popup.Show();
        }

        private static void showLoginPopup()
        {
            Popup popup = new Popup();
            popup.BackColor = Constants.LoginPopupColor;
            popup.message.Text = "Logged In!";
            popup.Show();
        }

        private void LogoutDeactivations()
        {
            this.messageBox.Enabled = false;
            this.messageBox.BackColor = Constants.Inactive;
            this.messageBox.Visible = false;
            this.MessagesListView.Visible = false;
            this.boardTableLayoutPnl.Visible = false;
            this.OnlineUsersTitle.Visible = false;
            this.GroupChatTitle.Visible = false;
            this.welcomeHaveFunLbl.Text = "You just logged out! Bye Bye!";
            this.usernameLinePnl.Visible = true;
            this.passwordLinePnl.Visible = true;
            this.onlineUsersLV.Visible = false;
            this.messageBox.Visible = false;
            this.sendMessageButton.Visible = false;
            this.sendMessagePnl.Visible = false;
            this.passwordPanel.Visible = true;
            this.usernamePanel.Visible = true;
            this.UsernameTB.Text = "Username...";
            this.PasswordTB.Text = "Password";
            this.UsernameTB.Enabled = true;

            this.sendMessageButton.Enabled = false;
            this.sendMessageButton.BackColor = Constants.Inactive;
            this.MessagesListView.Visible = false;
            this.UsernameTB.Visible = true;
            this.usernamePanel.Visible = true;
            this.usernameLinePnl.Visible = true;
            this.UsernameTB.Text = "Username...";
            this.PasswordTB.Text = "Password";
        }

        private void LogoutActivations()
        {
            this.UsernameTB.Enabled = true;

            this.PasswordTB.Enabled = true;
            this.PasswordTB.BackColor = Constants.TBActive;

            this.SignUpBtn.Enabled = true;
            this.SignUpBtn.Visible = true;
            this.SignUpBtn.BackColor = Constants.SignUpBtnActive;
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {

        }
        private void generateLoginMessage(ChatAppClasses.Message messageToSend)
        {
            messageToSend.MessageText = "Login Request";
            messageToSend.Type = "Login";
            messageToSend.username = UsernameTB.Text.ToString();
            messageToSend.password = PasswordTB.Text.ToString();
            myUser.username = messageToSend.username;
            myUser.password = messageToSend.password;
        }
        
        private void ActivateAdminInterface_login()
        {
            adminApp.Show();
            this.messageBox.Visible = true;
            this.welcomeHaveFunLbl.Text = "Have Fun, Admin " + myUser.username + "!";
            this.usernameLinePnl.Visible = false;
            this.passwordLinePnl.Visible = false;
            this.onlineUsersLV.Visible = true;
            this.messageBox.Visible = true;

            this.PasswordTB.Enabled = false;
            this.passwordPanel.Visible = false;
            this.PasswordTB.BackColor = Constants.Inactive;
            this.MessagesListView.Visible = true;
            this.boardTableLayoutPnl.Visible = true;
            this.OnlineUsersTitle.Visible = true;
            this.GroupChatTitle.Visible = true;

        }
        private void ActivateUserInterface_login()
        {
            this.UsernameTB.Visible = false;
            this.usernamePanel.Visible = false;
            this.usernameLinePnl.Visible = false;
            this.passwordPanel.Visible = false;
            this.passwordLinePnl.Visible = false;
            this.label1.Text = "Logged In!";
            this.MessagesListView.Visible = true;
            this.boardTableLayoutPnl.Visible = true;
            this.OnlineUsersTitle.Visible = true;
            this.GroupChatTitle.Visible = true;
            this.welcomeHaveFunLbl.Text = "Have Fun, " + myUser.username + "!";
            this.onlineUsersLV.Visible = true;
            this.messageBox.Visible = true;
            this.sendMessageButton.Visible = true;
            this.sendMessagePnl.Visible = true;

            this.LoginBtn.Text = "Logout";
            this.LoginBtn.BackColor = Constants.LogoutBtnActive;

            this.SignUpBtn.Enabled = false;
            this.SignUpBtn.Visible = false;
            this.SignUpBtn.BackColor = Constants.Inactive;

            this.messageBox.Enabled = true;
            this.messageBox.BackColor = Constants.TBActive;// Color.White;

            this.sendMessageButton.Enabled = true;
            this.sendMessageButton.BackColor = Constants.sendMsgBtnActive;

            this.ConnectionLabel.Text = "Connected";
            this.ConnectionLabel.ForeColor = Color.MediumSeaGreen;
        }
        private void messageBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm(this);
            settingForm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void onlineUsersLV_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (onlineUsersLV.SelectedItems.Count > 0)
            {
                int otherParticipant_index = onlineUsersLV.SelectedIndices[0];
                string otherParticipant_username = onlineUsersLV.Items[otherParticipant_index].Text;
                Console.WriteLine(otherParticipant_username);
                PrivateMessageForm privateMessageForm = userForms[otherParticipant_username];
                isPMFormOpen[onlineUsersLV.Items[otherParticipant_index].Text] = true;
                privateMessageForm.Show();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UsernameTB_TextChanged(object sender, EventArgs e)
        {
            this.Text = "";
        }

        private void UsernameTB_Enter(object sender, EventArgs e)
        {
            if (UsernameTB.Text == "Username...")
            {
                UsernameTB.Text = "";
                UsernameTB.ForeColor = Color.Black;
                usernameLinePnl.BackColor = Color.MediumSeaGreen;
                usernameLinePnl.Size = new Size(261, 5);
            }
        }

        private void UsernameTB_Leave(object sender, EventArgs e)
        {
            if (UsernameTB.Text == "")
            {
                UsernameTB.Text = "Username...";
                UsernameTB.ForeColor = Color.Silver;
                usernameLinePnl.BackColor = Color.DarkGray;
                usernameLinePnl.Size = new Size(261, 3);
            }
        }

        private void PasswordTB_Enter(object sender, EventArgs e)
        {
            if (PasswordTB.Text == "Password")
            {
                PasswordTB.Text = "";
                PasswordTB.ForeColor = Color.Black;
                passwordLinePnl.BackColor = Color.MediumSeaGreen;
                passwordLinePnl.Size = new Size(261, 5);
            }
        }

        private void PasswordTB_Leave(object sender, EventArgs e)
        {
            if (PasswordTB.Text == "")
            {
                PasswordTB.Text = "Password";
                PasswordTB.ForeColor = Color.Silver;
                passwordLinePnl.BackColor = Color.DarkGray;
                passwordLinePnl.Size = new Size(261, 3);
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void sendMessageButton_MouseHover(object sender, EventArgs e)
        {
            sendMessageButton.BackColor = Constants.TBActive;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if(!loggedIn)
                Application.Exit();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label3_MouseHover(object sender, EventArgs e)
        {

        }

        private void usernameLinePnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void boardLabel_Click(object sender, EventArgs e)
        {
            if (clientNumber > Constants.maxNumberOfPlayers)
                return;
            if (clientNumber == 1 && movesCount % 4 >= 2)
                return;
            if (clientNumber == 2 && movesCount % 4 < 2)
                return;

            if (!startedConnection)
            {
                startedConnection = true;
                connection = new connectionToServer();
                connection.client = new TcpClient(Dns.GetHostName(), connection.port);
                connection.networkStream = connection.client.GetStream();
            }
            BinaryFormatter formatter = new BinaryFormatter();

            ChatAppClasses.Message messageToSend = new ChatAppClasses.Message();
            Label clickedLabel = sender as Label;

            int positionOnBoard = -1;
            for (int i = 0; i < boardTableLayoutPnl.Controls.Count; i++)
                if (boardTableLayoutPnl.Controls[i] is Label && boardTableLayoutPnl.Controls[i] == clickedLabel)
                    positionOnBoard = i;
            Console.WriteLine("Pozitia clickuita: " + positionOnBoard);
            if (clickedLabel == null)
                Console.WriteLine("Error when clicking on icon!");
            if (clickedLabel.ForeColor != Color.White)
            {
                messageToSend.clickedIcon = clickedLabel.Text;
                Console.WriteLine("Clicked: " + messageToSend.clickedIcon);
                messageToSend.Type = "Icon Clicked";
                messageToSend.positionOnBoard = positionOnBoard;
                messageToSend.username = UsernameTB.Text.ToString();
                messageToSend.password = PasswordTB.Text.ToString();
                formatter.Serialize(connection.networkStream, messageToSend);
                connection.networkStream.Flush();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            if (!startedConnection)
            {
                startedConnection = true;
                connection = new connectionToServer();
                connection.client = new TcpClient(Dns.GetHostName(), connection.port);
                connection.networkStream = connection.client.GetStream();
            }
            BinaryFormatter formatter = new BinaryFormatter();

            ChatAppClasses.Message messageToSend = new ChatAppClasses.Message();

            messageToSend.Type = "New Game";

            formatter.Serialize(connection.networkStream, messageToSend);
            connection.networkStream.Flush();

        }
    }
}
