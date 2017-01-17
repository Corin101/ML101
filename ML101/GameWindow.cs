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
        public event GameWindowHandler AnotherGame;
        GameConfig game;
        public GameWindow()
        {
            InitializeComponent();        
        }
        /* start game method, configures the array and it's list (allocating the initial options) */
        public void StartGame()
        {
            game = new GameConfig(Int32.Parse(SticksInGame.Text), PlayerNameLabel.Text);
            game.AllocatePool();
            NewDisplay();
        }
        private void NewDisplay( bool NewGame = true)
        {
            DisplayTextBox.Clear();
            if (NewGame == false)
            {
                DisplayTextBox.AppendText("Game Status:: Won: " + game.gamescore[0] + " Lost: " + game.gamescore[1]);
                DisplayTextBox.AppendText(Environment.NewLine);
            }
            DisplayTextBox.AppendText("Welcome to the game, " + PlayerNameLabel.Text + " will start the game!");
            DisplayTextBox.AppendText(Environment.NewLine);
            DisplayTextBox.AppendText("Sticks left in the game:: " + SticksInGame.Text);
            DisplayTextBox.AppendText(Environment.NewLine);
        }
        /* checkup if enter is pressed */
        private void PlayerPickTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                takeButton_Click(this, new EventArgs());
            }
        }
        public void NewGame(string condition)
        {
            if (game.VictoryCondition == true)
            {
                game.SaveSoftMemory();            
                game.gamescore[0] += 1;
                SetNewGame();
            }
            else
            {
                game.NewMemory();
                game.gamescore[1] += 1;
                SetNewGame();
            }
            if (condition == "exit")
                game.SaveHardMemory();
        }

        private void SetNewGame()
        {
            game.NumberOfSticks = game.poolSize;
            SticksInGame.Text = game.NumberOfSticks.ToString();
            PlayerNameLabel.Text = game.PlayerName;
            game.VictoryCondition = null;
            NewDisplay(false);
            AnotherGame();
        }

        private async void  takeButton_Click(object sender, EventArgs e)
        {
            if (!LegalMoveCheck())
                return;
            game.PlayerTurn(Int32.Parse(PlayerPickTextBox.Text));
            StatusUpdate();

            PlayerPickTextBox.Text = "";
            if (CheckVictory() != null)
                return;
            
            await Task.Delay(1000);
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
            
            if (!Int32.TryParse(PlayerPickTextBox.Text, out sticksPicked))
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
