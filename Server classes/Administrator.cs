using System;
using System.Collections.Generic;
using System.Text;

namespace Server
{
    public class Administrator : User
    {
        public Administrator(string username, string password):base(username, password)
        {
        }
        public void blockUser(User user)
        {
            Server_class.serverDatabase.BlockUser(user);
        }
        public void unblockUser(User user)
        {
            Server_class.serverDatabase.UnblockUser(user);
        }
        public void warnUser(User user)
        {

        }
        public void deleteUserAccount(User user)
        {
            Server_class.serverDatabase.DeleteUser(user);
        }
        public override void logToConsoleLogin()
        {
            System.Console.WriteLine("Admin Log: Administrator: " + this.username + " is now ONLINE!");
        }
        public override void logToConsoleLogout()
        {
            System.Console.WriteLine("Admin Log: Administrator has logged out!");
        }
        public override void logToConsoleDetails()
        {
            System.Console.WriteLine(this.username + " (Administrator)");
        }
    }
}
