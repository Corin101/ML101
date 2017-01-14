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
    public partial class MainWindow : UserControl
    {
        public MainWindow()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = @"img\main.bmp";
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

        }

    }
}
