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
            gameEnd1.Visible = false;
            inputSticksError1.Visible = false;
            mainWindow1.Visible = true;
            about1.Visible = false;
            gameWindow1.Visible = false;
            gameOptions1.Visible = false;

            CenterWindows();
        }

        public void Subscribe()
        {
            mainWindow1.ButtonClick += MainWindow1_ButtonClick;
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
                    break; 
            }

        }
        private void CenterWindows()
        {
            CenterWindow(mainWindow1);
            CenterWindow(gameEnd1);
            CenterWindow(inputSticksError1);
            CenterWindow(about1);
            CenterWindow(gameWindow1);
            CenterWindow(gameOptions1);
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
