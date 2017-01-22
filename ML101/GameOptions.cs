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
    public delegate void OptionsWindowHandler(string playerName, string NumOfSticks);
    public partial class GameOptions : UserControl
    {
        public event OptionsWindowHandler ButtonClick;
        public GameOptions()
        {
            InitializeComponent();
            WarningLabel.Visible = false;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            string playerName = "Player1";
            int sticks = 0;
            if (!Int32.TryParse(SticksTextBox.Text, out sticks))
            { 
                WarningLabel.Visible = true;
                return;
            }
            if (PlayerNameTextBox.Text != "")
                playerName = PlayerNameTextBox.Text;

            if (sticks < 5 || sticks > 50)
                WarningLabel.Visible = true;
            else
                ButtonClick(playerName, sticks.ToString());
        }
        /// <summary>
        /// Checks if Eneter key was pressed
        /// </summary>
        private void SticksTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StartButton_Click(this, new EventArgs());
            }
        }
    }
}
