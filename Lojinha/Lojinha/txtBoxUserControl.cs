using System;
using System.Windows.Forms;

namespace Lojinha
{
    public partial class txtBoxUserControl : UserControl
    {
        public txtBoxUserControl()
        {
            InitializeComponent();
            label1.Visible = false;
        }

        private void userControlTxtBox_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Visible = true;
        }

        private void userControlTxtBox_Leave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
    }
}
