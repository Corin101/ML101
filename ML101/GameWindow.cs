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
    public delegate void GameWindowHandler();
    public partial class GameWindow : UserControl
    {
        public event GameWindowHandler StickPickError;
        GameConfig game;
        public GameWindow()
        {
            InitializeComponent();        
        }

        public void StartGame()
        {
            game = new GameConfig(Int32.Parse(SticksInGame.Text), PlayerNameLabel.Text);
            DisplayTextBox.AppendText("Welcome to the game, ");
            DisplayTextBox.AppendText(PlayerNameLabel.Text);
            DisplayTextBox.AppendText(" will start the game!");
            DisplayTextBox.AppendText(Environment.NewLine);
            DisplayTextBox.AppendText("Sticks left in the game:: ");
            DisplayTextBox.AppendText(SticksInGame.Text);
        }
        private void PlayerPickTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                takeButton_Click(this, new EventArgs());
            }
        }

        private void takeButton_Click(object sender, EventArgs e)
        {
            LegalMoveCheck();  
        }

        private void LegalMoveCheck()
        {
            int sticksPicked = 0;
            if (PlayerPickTextBox.Text == "")
                StickPickError();
            else
                sticksPicked = Int32.Parse(PlayerPickTextBox.Text);
            if (sticksPicked < 1 || sticksPicked > 3)
                StickPickError();

        }
    }
}
