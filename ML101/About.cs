using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ML101
{
    public partial class About : UserControl
    {
        public About()
        {
            InitializeComponent();
            textbox1.Font = new Font(textbox1.Font.FontFamily, 14);
            textbox1.TextAlign = HorizontalAlignment.Center;
            textbox1.Text = AboutText();
            textbox1.ReadOnly = true;
        }

        private string AboutText()
        {
            StringBuilder text = new StringBuilder();
            text.Append(Environment.NewLine);
            text.Append(" This game was developed in an attempt to learn some new skills. ");
            text.Append("The game is a simple stick game where you win if you force your opponent to pick up ");
            text.Append("the last stick from the board.The opponent in this case is an algorithm that ");
            text.Append("has the ability to learn from the mistakes it made in previous game. That is to say, ");
            text.Append("the algorithm learns when it makes good decisions (wins a game). It’s a simple algorithm, ");
            text.Append("and as such it has plenty of flaws, like keeping all possible states of the game ");
            text.Append("in the memory, but for this example it is sufficient and it works.");
            return text.ToString();
        }
    }
}
    