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
    public delegate void GameEndHandler(string decision);
    public partial class GameEnd : UserControl
    {
        public event GameEndHandler AfterEndDecision;
        public GameEnd()
        {
            InitializeComponent();           
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            AfterEndDecision("Play");
        }

        private void ExitGameButton_Click(object sender, EventArgs e)
        {
            AfterEndDecision("Exit");
        }
    }
}
