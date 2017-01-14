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
    public partial class InputSticksError : UserControl
    {
        public InputSticksError()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = @"img\wns.bmp";
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
    }
}
