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
    public delegate void AboutWindowHandler(string buttonId);
    public partial class About : UserControl
    {
        public event AboutWindowHandler ButtonClick;
        public About()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = @"img\about.bmp";
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }


        private void OkButton_Click(object sender, EventArgs e)
        {
            ButtonClick("Ok");
        }
    }
}
    