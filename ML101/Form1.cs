using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ML101
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();         
            InitialWindowState();
            CenterWindows();
            Subscribe();
        }

        public void Subscribe()
        {
            mainWindow1.ButtonClick += MainWindow1_ButtonClick;
            rules1.ButtonClick += Rules1_ButtonClick;
            about1.ButtonClick += About1_ButtonClick;
            gameOptions1.ButtonClick += GameOptions1_ButtonClick;
            gameWindow1.StickPickError += GameWindow1_StickPickError;
            inputSticksError1.ErrorResolved += InputSticksError1_ErrorResolved;
        }

        private void InputSticksError1_ErrorResolved()
        {
            gameWindow1.PlayerPickTextBox.Text = "";
            inputSticksError1.Visible = false;
            gameWindow1.Visible = true;
        }

        private void GameWindow1_StickPickError(bool condition)
        {
            gameWindow1.Visible = false;
            inputSticksError1.Visible = true;
        }

        private void GameOptions1_ButtonClick(string playerName, string NumOfSticks)
        {
            gameOptions1.Visible = false;
            gameWindow1.Visible = true;
            gameWindow1.PlayerNameLabel.Text = playerName;
            gameWindow1.SticksInGame.Text = NumOfSticks;
            gameWindow1.StartGame();
        }

        private void About1_ButtonClick(string buttonId)
        {
            about1.Visible = false;
            mainWindow1.Visible = true;
        }

        private void Rules1_ButtonClick(string buttonId)
        {
            rules1.Visible = false;
            mainWindow1.Visible = true;
        }

        private void MainWindow1_ButtonClick(string buttonId)
        {
            switch (buttonId)
            {
                case "AboutButton":
                    mainWindow1.Visible = false;
                    about1.Visible = true;
                    break;
                case "GameStart":
                    mainWindow1.Visible = false;
                    gameOptions1.Visible = true;
                    break;
                case "Rules":
                    mainWindow1.Visible = false;
                    rules1.Visible = true;
                    break; 
            }
        }

        private void InitialWindowState()
        {
            gameEnd1.Visible = false;
            inputSticksError1.Visible = false;
            mainWindow1.Visible = true;
            about1.Visible = false;
            gameWindow1.Visible = false;
            gameOptions1.Visible = false;
            rules1.Visible = false;
        }
        private void CenterWindows()
        {
            CenterWindow(mainWindow1);
            CenterWindow(gameEnd1);
            CenterWindow(inputSticksError1);
            CenterWindow(about1);
            CenterWindow(gameWindow1);
            CenterWindow(gameOptions1);
            CenterWindow(rules1);
        }
        private void CenterWindow(UserControl control)
        {
            control.Anchor = AnchorStyles.None;
            control.Location = new Point((control.Parent.ClientSize.Width / 2) - (control.Width / 2),
                                         (control.Parent.ClientSize.Height / 2) - (control.Height / 2));
            control.Refresh();
        }
    }
}
