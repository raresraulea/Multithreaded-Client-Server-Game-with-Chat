using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Timers;
using ChatAppClasses;

namespace Server
{
    public class Server_class
    {
        public static int playersConnected = 0;
        public static Database serverDatabase;
        static Random random = new Random();
        public static int totalMoves = 0;
        public int player1Guesses = 0;
        public int player2Guesses = 0;
        public List<string> icons = new List<string>
        {
            "p", "p", "f", "f", "h", "h", "j", "j",
            "k", "k", "l", "l", "v", "v", "b", "b"
        };
        public ArrayList usernameList = new ArrayList(); //estimare: maxim 15 playeri pe server
        public string firstIcon = null;
        public int firstIconPosition;
        public string secondIcon = null;
        public int secondIconPosition;
        List<User> onlineAdmins = new List<User>(); //va contine elemente de tip Administrator, clasa derivata
        List<User> onlineUsers = new List<User>(); //va contine elemente de tip User, clasa de baza
        List<User> onlineUsersAndAdmins = new List<User>(); //va contine si elemente de tip User si Administrator

        //lista clientilor sub forma unei perechi username - TcpClient
        Dictionary<string, TcpClient> clientList = new Dictionary<string, TcpClient>();

        public void connectToDatabase(Database database)
        {
            serverDatabase = database;
            Console.WriteLine("Connected to Database...");
        }
        public void run()
        {
            clientList.Clear();
            Shuffle(icons);

            TcpListener listener = new TcpListener(System.Net.IPAddress.Any, 1302);
            listener.Start();

            Console.WriteLine("Server started...");

            while (true)
            {
                Console.WriteLine("Waiting for connection...");
                TcpClient client = acceptConnectionToClient(listener);
                NetworkStream networkStream = client.GetStream();
                try
                {
                    if (!clientList.ContainsValue(client))
                    {
                        var thread = new Thread(() => handleIncomingMessage(client));
                        thread.Start();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Failed to start..." + e.Message);
                }
            }
        }
        public void handleIncomingMessage(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            IFormatter formatter = new BinaryFormatter();

            ChatAppClasses.Message messageFromClient;
            messageFromClient = (ChatAppClasses.Message)formatter.Deserialize(stream);

            bool flag_first = true; //pentru evitarea deserializarii duble in while(true) la prima conexiune

            try
            {
                if (!clientList.ContainsValue(client))
                    clientList.Add(messageFromClient.username, client);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error connecting to server!");
            }

            KeyValuePair<string, TcpClient> clientInDictionary;
            clientInDictionary = clientList.First(dictionaryItem => dictionaryItem.Value == client);
            Console.WriteLine("Handling " + clientInDictionary.Key);

            while (true)
            {
                try
                {
                    stream = client.GetStream();
                    StreamWriter streamWriter = new StreamWriter(stream);
                    if (!flag_first)
                        messageFromClient = (ChatAppClasses.Message)formatter.Deserialize(stream);
                    string response = calculateResponseByMessageType(client, messageFromClient, ref flag_first);
                    Console.WriteLine("The response sent by the server: " + response);
                    sendMessageBackToClient(stream, formatter, response);
                    if (response == Constants.response_wrongCredentials)
                    {
                        removeClientFromOnlineUsers(client);
                        break;
                    }
                    handleType_message(messageFromClient);
                    if (messageFromClient.Type == Constants.messageType_logout || messageFromClient.Type == Constants.messageType_signUp)
                    {
                        stream.Close();
                        break;
                    }
                    Console.WriteLine("Finished handling for: " + clientInDictionary.Key);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Reading error: " + e.Message);
                    break;
                }
            }
            Console.WriteLine("Thread terminated through Logout!");
        }
        public static void Shuffle(List<string> ts)
        {
            var count = ts.Count;
            var last = count - 1;
            for (var i = 0; i < last; ++i)
            {
                var r = random.Next(0, count);
                var tmp = ts[i];
                ts[i] = ts[r];
                ts[r] = tmp;
            }
        }

        private void handleType_message(ChatAppClasses.Message messageFromClient)
        {
            if (messageFromClient.Type == Constants.messageType_broadcastMessage)
                messageFromClient.Type = Constants.messageType_message;

            if (messageFromClient.Type == Constants.messageType_message || messageFromClient.Type == Constants.messageType_privateMessage)
            {
                Console.WriteLine("Saving message to Database...");
                cropUsernameFromMessage(messageFromClient);
                Server_class.serverDatabase.saveMessageToDb(messageFromClient);
            }
        }

        private void removeClientFromOnlineUsers(TcpClient client)
        {
            var clientToRemove = clientList.First(dictionaryItem => dictionaryItem.Value == client);
            clientList.Remove(clientToRemove.Key);
        }

        private static void sendMessageBackToClient(NetworkStream stream, IFormatter formatter, string response)
        {
            ChatAppClasses.Message messageToSend = new ChatAppClasses.Message();
            messageToSend.MessageText = response;
            messageToSend.clientNumber = playersConnected;

            formatter.Serialize(stream, messageToSend);
            stream.Flush();
        }

        private string calculateResponseByMessageType(TcpClient client, ChatAppClasses.Message messageFromClient, ref bool flag_first)
        {
            string response = "";
            User user = new User(messageFromClient.username, messageFromClient.password);
            switch (messageFromClient.Type)
            {
                case Constants.messageType_connection:
                    response = "Connected";
                    flag_first = false;
                    break;

                case Constants.messageType_message:
                    ChatAppClasses.Message messageToBroadcast = new ChatAppClasses.Message();
                    messageToBroadcast = messageFromClient;
                    broadcastMessage(messageToBroadcast);
                    sendBoard(client);
                    response = "Message handled!";
                    break;
                case Constants.messageType_privateMessage: //cazul in care se incearca trimiterea unui mesaj privat
                    KeyValuePair<string, TcpClient> clientToSend = getReceiverClient(messageFromClient);
                    Console.WriteLine(messageFromClient.Sender + ", receiver: " + messageFromClient.Receiver + ", msg: " + messageFromClient.MessageText);
                    sendPrivateMessage(messageFromClient, clientToSend);
                    response = "Message handled!";
                    break;

                case Constants.messageType_login: //cazul in care se primeste un LoginRequest
                    response = handleLogin(user);
                    Console.WriteLine("Entity accepted: " + user.verifyIdentity());
                    if (user.verifyIdentity())
                    {
                        if (response == "Logged In!" || response == "Welcome, Admin!")
                        {
                            if (response == "Welcome, Admin!")
                            {
                                user.accessLevel = "Admin";
                                User newAdmin = new Administrator(user.username, user.password);
                                newAdmin.username = user.username;
                                newAdmin.logToConsoleLogin();
                                onlineAdmins.Add(newAdmin);
                                onlineUsersAndAdmins.Add(newAdmin);
                            }
                            else
                            {
                                user.logToConsoleLogin();
                                onlineUsers.Add(user);
                                onlineUsersAndAdmins.Add(user);
                            }

                            playersConnected++;
                            sendUsersList(); //actualizez lista celor online catre toti clientii conectati
                            sendBoard(client); //trimit tabla generata de server catre clientul care s-a logat
                        }
                        Console.WriteLine("Online Users (" + onlineUsersAndAdmins.Count() + "): ");
                        onlineUsersAndAdmins.ForEach(user => user.logToConsoleDetails());
                        flag_first = false;
                    }
                    else response = Constants.response_wrongCredentials;
                    break;

                case Constants.messageType_logout:
                    playersConnected--;
                    var clientToBeRemoved = clientList.First(dictionaryItem => dictionaryItem.Value == client);
                    clientList.Remove(clientToBeRemoved.Key);
                    if (clientList.Count() == 0)
                        totalMoves = 0;
                    if (clientIsAdmin(clientToBeRemoved))
                    {
                        User adminRemoved = onlineAdmins.First(item => item.username == user.username);
                        onlineAdmins.Remove(adminRemoved);
                        onlineUsersAndAdmins.Remove(adminRemoved);
                        adminRemoved.logToConsoleLogout();
                    }
                    else
                    {
                        User userToBeRemoved = onlineUsers.First(u => u.username == clientToBeRemoved.Key);
                        userToBeRemoved.logToConsoleLogout();
                        onlineUsers.Remove(userToBeRemoved);
                        onlineUsersAndAdmins.Remove(userToBeRemoved);
                    }
                    if(clientList.Count() == 0)
                    {
                        Shuffle(icons);
                        totalMoves = 0;
                        player1Guesses = 0;
                        player2Guesses = 0;
                        firstIcon = null;
                        secondIcon = null;
                        firstIconPosition = -1;
                        secondIconPosition = -1;
                    }
                    Console.WriteLine("Online Users (" + onlineUsersAndAdmins.Count() + "): ");
                    onlineUsersAndAdmins.ForEach(user => user.logToConsoleDetails());
                    response = "Logged Out!";
                    sendUsersList();
                    break;

                case Constants.messageType_signUp:
                    response = handleSignUp(new User() { username = messageFromClient.username, password = messageFromClient.password });
                    var clientToRemove = clientList.First(dictionaryItem => dictionaryItem.Value == client);
                    clientList.Remove(clientToRemove.Key);
                    break;

                case "New Game":
                    totalMoves = 0;
                    foreach(var current_client in clientList)
                    {
                        sendBoard(current_client.Value);
                    }
                    break;
                case "Icon Clicked":

                    string current_player = totalMoves % 4 < 2 ? "player1" : "player2";
                    Color iconColor = current_player == "player1" ? Color.Chocolate : Color.LightCoral;
                    Console.WriteLine("Total Moves: " + totalMoves);
                    Console.WriteLine("Player moving: " + current_player);
                    Console.WriteLine("Icon clicked: " + messageFromClient.clickedIcon);
                    string moreGuessesBeforeThis = player1Guesses > player2Guesses ? "Player 1" : "Player 2";
                    if (firstIcon != null && secondIcon != null)
                        break;
                    if (firstIcon == null)
                    {
                        firstIcon = messageFromClient.clickedIcon;
                        firstIconPosition = messageFromClient.positionOnBoard;
                        messageFromClient.iconColor = iconColor;
                        broadcastClickedIcon(messageFromClient);
                    }
                    else
                    {
                        secondIcon = messageFromClient.clickedIcon;
                        secondIconPosition = messageFromClient.positionOnBoard;
                        messageFromClient.iconColor = iconColor;
                        broadcastClickedIcon(messageFromClient);

                        if (secondIcon == firstIcon)
                        {
                            if (current_player == "player1")
                            {
                                Console.WriteLine("Player1 guessed! ");
                                player1Guesses++;
                            }
                            else
                            {
                                Console.WriteLine("Player2 guessed! ");
                                player2Guesses++;
                            }
                        }
                        else
                        {
                            ChatAppClasses.Message messageToBroadcast1 = messageFromClient;
                            messageToBroadcast1.Type = "redrawPositions";
                            messageToBroadcast1.firstPositionToRedraw = this.firstIconPosition;
                            messageToBroadcast1.secondPositionToRedraw = this.secondIconPosition;
                            Thread.Sleep(750);
                            foreach (var current_client in clientList)
                            {
                                var stream = current_client.Value.GetStream();
                                IFormatter formatter = new BinaryFormatter();
                                formatter.Serialize(stream, messageToBroadcast1);
                                stream.Flush();
                            }
                        }

                        firstIcon = null;
                        secondIcon = null;

                    }
                    if (player1Guesses + player2Guesses == 8)
                    {
                        string winner = player1Guesses > player2Guesses ? "Player 1" : "Player 2";
                        if (player1Guesses == player2Guesses) winner = moreGuessesBeforeThis;
                        ChatAppClasses.Message messageToBroadcast2 = messageFromClient;
                        messageToBroadcast2.Type = "Winner";
                        messageToBroadcast2.MessageText = winner;
                        foreach (var current_client in clientList)
                        {
                            var stream = current_client.Value.GetStream();
                            IFormatter formatter = new BinaryFormatter();
                            formatter.Serialize(stream, messageToBroadcast2);
                            stream.Flush();
                        }
                        Shuffle(icons);
                        totalMoves = 0;
                        player1Guesses = 0;
                        player2Guesses = 0;
                        firstIcon = null;
                        secondIcon = null;
                        firstIconPosition = -1;
                        secondIconPosition = -1;
                    }
                    totalMoves++;
                    break;

                default:
                    response = "Error";
                    break;
            }

            return response;
        }

        private bool clientIsAdmin(KeyValuePair<string, TcpClient> clientToBeRemoved)
        {
            foreach (var item in onlineAdmins)
            {
                if (item.username == clientToBeRemoved.Key)
                    return true;
            }
            return false;
        }

        private KeyValuePair<string, TcpClient> getReceiverClient(ChatAppClasses.Message messageFromClient)
        {
            return clientList.First(dictionaryItem => dictionaryItem.Key == messageFromClient.Receiver);
        }

        private static void sendPrivateMessage(ChatAppClasses.Message messageFromClient, KeyValuePair<string, TcpClient> clientToSend)
        {
            var stream = clientToSend.Value.GetStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, messageFromClient);
            stream.Flush();
        }

        private void cropUsernameFromMessage(ChatAppClasses.Message message)
        {
            string updatedMessageText = "";
            bool encounteredSpace = false;
            for (var i = 0; i < message.MessageText.Length; i++)
            {
                if (encounteredSpace)
                    updatedMessageText += message.MessageText[i];
                else if (message.MessageText[i] == ' ')
                    encounteredSpace = true;
            }
            message.MessageText = updatedMessageText;
        }
        private void sendBoard(TcpClient client)
        {
            ChatAppClasses.Message shuffledIconsMessage = new ChatAppClasses.Message();
            shuffledIconsMessage.Type = "shuffledIcons";
            shuffledIconsMessage.shuffledIconsList = icons;
            //Console.WriteLine("Trimit catre client lista: ");
            //shuffledIconsMessage.shuffledIconsList.ForEach(a => Console.Write(a + " "));

            var stream = client.GetStream();
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, shuffledIconsMessage);
            stream.Flush();

        }
        private void sendUsersList()
        {
            List<string> list = new List<string>();

            foreach (var client in clientList)
            {
                list.Add(client.Key);
            }

            ChatAppClasses.Message onlineUsersList = new ChatAppClasses.Message();
            onlineUsersList.Type = "List";
            onlineUsersList.onlineUser = list;

            foreach (var client in clientList)
            {
                var stream = client.Value.GetStream();
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, onlineUsersList);
                stream.Flush();
            }
        }
        private void broadcastMessage(ChatAppClasses.Message messageToBroadcast)
        {
            messageToBroadcast.Type = "broadcastMessage";
            messageToBroadcast.MessageText = messageToBroadcast.username + ": " + messageToBroadcast.MessageText;
            foreach (var client in clientList)
            {
                var stream = client.Value.GetStream();
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, messageToBroadcast);
                stream.Flush();
            }
        }
        private void broadcastClickedIcon(ChatAppClasses.Message messageToBroadcast)
        {
            messageToBroadcast.Type = "broadcastIcon"; ;
            foreach (var client in clientList)
            {
                var stream = client.Value.GetStream();
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, messageToBroadcast);
                stream.Flush();
            }
        }

        private static TcpClient acceptConnectionToClient(TcpListener listener)
        {
            TcpClient client = listener.AcceptTcpClient();

            Console.WriteLine();
            Console.WriteLine("Client accepted...");

            return client;
        }

        public static string handleLogin(User user)
        {
            Login login = Login.Instance;

            string loginResponse = login.verifyLoginData(user);

            return loginResponse;
        }

        public string handleSignUp(User user)
        {
            SignUp signUp = SignUp.Instance;
            return SignUp.signUp(user);
        }


        public static void saveMessageToDB(ChatAppClasses.Message message)
        {
            serverDatabase.saveMessageToDb(message);
        }

    }
}
