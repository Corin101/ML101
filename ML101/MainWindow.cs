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
    public delegate void ButtonHandler(string buttonId);
    public partial class MainWindow : UserControl
    {
        
        public event ButtonHandler ButtonClick;
        public MainWindow()
        {
            InitializeComponent();
            
            pictureBox1.ImageLocation = @"img\main.bmp";
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            ButtonClick("AboutButton");
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            ButtonClick("GameStart");
        }

        private void RulesButton_Click(object sender, EventArgs e)
        {
            ButtonClick("Rules");
        }
    }
}
