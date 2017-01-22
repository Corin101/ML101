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
        /// <summary>
        /// start game method, configures the array and it's list (allocating the initial options)
        /// </summary>
        public void StartGame()
        {
            game = new GameConfig(Int32.Parse(SticksInGame.Text), PlayerNameLabel.Text);
            game.AllocatePool();
            NewDisplay();
        }
        /// <summary>
        /// Turn sequence (player turn, computer turn)
        /// </summary>

        private async void takeButton_Click(object sender, EventArgs e)
        {
            if (!LegalMoveCheck())
                return;
            game.PlayerTurn(Int32.Parse(PlayerPickTextBox.Text));
            StatusUpdate();

            PlayerPickTextBox.Text = "";
            if (CheckVictory() != null)
                return;

            await Task.Delay(500);
            game.ComputerTurn();
            StatusUpdate();
            CheckVictory();
        }
        /// <summary>
        /// Displayes the game status to the screen, if not the first game,
        /// displays current win/loss ratio.
        /// </summary>
        /// <param name="NewGame"></param>
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
        /// <summary>
        /// checkup if enter is pressed
        /// </summary>
        private void PlayerPickTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                takeButton_Click(this, new EventArgs());
            }
        }
        /// <summary>
        /// after game setup, adding the memory of last game to the pool
        /// setup of new game, or saving everything to mind.txt if exit
        /// was pressed
        /// </summary>
        /// <param name="condition">new game or exit game</param>
        public void NewGame(string condition)
        {
            if (game.VictoryCondition == true)
            {
                game.SaveSoftMemory();
                if (condition == "exit")
                {
                    game.SaveHardMemory();
                    return;
                }      
                game.gamescore[0] += 1;
                SetNewGame();
            }
            else
            {
                game.SaveSoftMemory();
                if (condition == "exit")
                {
                    game.SaveHardMemory();
                    return;
                }
                game.gamescore[1] += 1;
                SetNewGame();
            }
        }
        /// <summary>
        /// New game setup, reseting the victory condition, reseting
        /// number of sticks and current player.
        /// </summary>
        private void SetNewGame()
        {
            game.NumberOfSticks = game.poolSize;
            SticksInGame.Text = game.NumberOfSticks.ToString();
            PlayerNameLabel.Text = game.PlayerName;
            game.VictoryCondition = null;
            NewDisplay(false);
            AnotherGame();
        }
        /// <summary>
        /// Updates the current game status screen after each turn
        /// </summary>
        private void StatusUpdate()
        {
            WriteResult();
            SticksInGame.Text = game.NumberOfSticks.ToString();
            SetName();
        }
        /// <summary>
        /// Display screen message after each turn
        /// </summary>
        private void WriteResult()
        {
            DisplayTextBox.AppendText(PlayerNameLabel.Text + " has taken " + game.SticksTaken.ToString() + " sticks.");
            DisplayTextBox.AppendText(Environment.NewLine);
            DisplayTextBox.AppendText("Sticks left in the game:: " + game.NumberOfSticks.ToString());
            DisplayTextBox.AppendText(Environment.NewLine);
        }
        /// <summary>
        /// Sets the name on the display for the current player
        /// </summary>
        private void SetName()
        {
            if (PlayerNameLabel.Text == "Computer")
                PlayerNameLabel.Text = game.PlayerName;
            else
                PlayerNameLabel.Text = "Computer";
        }
        /// <summary>
        /// Victory condition checkup
        /// </summary>
        /// <returns>true if player won, false if computer won, null if game still in progress</returns>
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
        /// <summary>
        /// Checks if the player picked the correct amount of sticks (1-3)
        /// </summary>
        /// <returns></returns>
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
