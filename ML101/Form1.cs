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
            gameEnd1.Visible = false; ;
            inputSticksError1.Visible = false;
            mainWindow1.Visible = true;
            
            CenterWindow(mainWindow1);
            CenterWindow(gameEnd1);
            CenterWindow(inputSticksError1);
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
