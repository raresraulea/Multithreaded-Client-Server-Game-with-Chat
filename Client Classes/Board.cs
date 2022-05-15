using System.Collections.Generic;

namespace Client_App
{
    public class Board
    {
        private Form1 form1;
        public List<string> icons;
        public System.Windows.Forms.TableLayoutPanel board;

        public Board(Form1 form1)
        {
            this.form1 = form1;
            board = form1.boardTableLayoutPnl;
        }
    }
}