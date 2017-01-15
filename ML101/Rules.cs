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
    public partial class Rules : UserControl
    {
        public Rules()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = @"img\rules.bmp";
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}
