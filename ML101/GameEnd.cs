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
    public partial class GameEnd : UserControl
    {
        public GameEnd()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = @"img\win.bmp";
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
    }
}
