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
    public delegate void RulesWindowHandler(string buttonId);
    public partial class Rules : UserControl
    {
        public event RulesWindowHandler ButtonClick;
        public Rules()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = @"img\rules.bmp";
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            ButtonClick("GotIt");
        }
    }
}
