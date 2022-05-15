using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_App
{
    class Constants
    {
        internal static Color Inactive = Color.LightGray;
        internal static Color LoginBtnActive = Color.MediumSeaGreen;
        internal static Color ConnectBtnActive = Color.MediumSeaGreen;
        internal static Color SignUpBtnActive = Color.RoyalBlue;
        internal static Color TBActive = Color.FromArgb(230,230,230);
        internal static Color sendMsgBtnActive= TBActive;
        internal static Color WarnBtnActive = Color.LightSalmon;
        internal static Color DisconnectBtnActive = Color.LightSalmon;
        internal static Color LogoutBtnActive = Color.LightSalmon;
        internal static Color DisconnectPopupColor = Color.DarkOrange;
        internal static Color SignUpPopupColor = Color.RoyalBlue;
        internal static Color LoginPopupColor = Color.MediumSeaGreen;
        internal static Color LogoutPopupColor = Color.DarkOrange;
        internal static Color WrongCredentialsPopupColor= Color.DarkOrange;
        internal static int boardColumns = 4;
        internal static int boardRows = 4;
        internal static int maxNumberOfPlayers = 2;
        public const string UserLoginSuccessResponse = "Logged In!";
        public const string WelcomeAdminResponse = "Welcome, Admin!" ;
        public const string WrongCredentialsResponse = "Wrong Credentials!";
    }
}
