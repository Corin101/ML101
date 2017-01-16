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
    public delegate void GameWindowHandler(bool? condition = null);
    public partial class GameWindow : UserControl
    {
        public event GameWindowHandler StickPickError;
        public event GameWindowHandler VictoryCondition;
        GameConfig game;
        public GameWindow()
        {
            InitializeComponent();        
        }

        public void StartGame()
        {
            game = new GameConfig(Int32.Parse(SticksInGame.Text), PlayerNameLabel.Text);
            game.AllocatePool();
            DisplayTextBox.AppendText("Welcome to the game, " + PlayerNameLabel.Text + " will start the game!");
            DisplayTextBox.AppendText(Environment.NewLine);
            DisplayTextBox.AppendText("Sticks left in the game:: " + SticksInGame.Text);
            DisplayTextBox.AppendText(Environment.NewLine);
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
            if (!LegalMoveCheck())
                return;
            game.PlayerTurn(Int32.Parse(PlayerPickTextBox.Text));
            StatusUpdate();

            if (CheckVictory() != null)
                return;
            PlayerPickTextBox.Text = "";

            game.ComputerTurn();
            StatusUpdate();
            CheckVictory();
        }
        private void StatusUpdate()
        {
            WriteResult();
            SticksInGame.Text = game.NumberOfSticks.ToString();
            SetName();
        }

        private void WriteResult()
        {
            DisplayTextBox.AppendText(PlayerNameLabel.Text + " has taken " + game.SticksTaken.ToString() + " sticks.");
            DisplayTextBox.AppendText(Environment.NewLine);
            DisplayTextBox.AppendText("Sticks left in the game:: " + game.NumberOfSticks.ToString());
            DisplayTextBox.AppendText(Environment.NewLine);
        }

        private void SetName()
        {
            if (PlayerNameLabel.Text == "Computer")
                PlayerNameLabel.Text = game.PlayerName;
            else
                PlayerNameLabel.Text = "Computer";
        }
        private bool? CheckVictory()
        {
            if (game.VictoryCondition == false)
            {
                VictoryCondition(false);
                return false;
            }
            if (game.VictoryCondition == true)
            {
                VictoryCondition(true);
                return true;
            }
            return null;
        }

        private bool LegalMoveCheck()
        {
            int sticksPicked = 0;
            if (PlayerPickTextBox.Text == "")
            {
                StickPickError();
                return false;
            }

            sticksPicked = Int32.Parse(PlayerPickTextBox.Text);

            if (sticksPicked < 1 || sticksPicked > 3)
            {
                StickPickError();
                return false;
            }

            if (sticksPicked > Int32.Parse(SticksInGame.Text))
            {
                StickPickError();
                return false;
            }

            return true;
        }
    }
}
