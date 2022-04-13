using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;


namespace XO
{
    public class Gracz
    {
        public string nick;
        public bool xo;
        public Color color;
        public Gracz(string nick, bool xo)
        {
            this.nick = nick;  this.xo = xo;
        }
        public string WstawXO()
        {
            if (xo == true)
            {
                string symbol = "X";
                color = Colors.Red;
                return symbol;
            }
            else
            {
                string symbol = "O";
                color = Colors.Blue;
                return symbol;
            } 
        }

    }
}
