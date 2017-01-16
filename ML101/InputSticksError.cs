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
    public delegate void InputErrorHandler();
    public partial class InputSticksError : UserControl
    {
        public event InputErrorHandler ErrorResolved;
        public InputSticksError()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = @"img\wns.bmp";
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            ErrorResolved();
        }
    }
}
