using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lojinha
{
    public partial class textBoxUserControl : UserControl
    {
        Regex r = new Regex("[^A-Z0-9~.$ ]$");
        bool gerouErro = false;

        // CONSTRUTOR
        public textBoxUserControl()
        {
            InitializeComponent();
        }

        // MÉTODOS EVENTOS
        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (gerouErro)
            {
                textBoxEscrever_Error();
            } else
            {
                textBoxNormal.BackgroundImage = Properties.Resources.txtBoxFocus;
            }
        }

        private void textBoxEscrever_Leave(object sender, EventArgs e)
        {
            textBoxNormal.BackgroundImage = Properties.Resources.txtBox1;
        }

        private void textBoxEscrever_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!textBoxEscrever.Text.Equals("") && textBoxEscrever.Text.Length >= 4 && r.IsMatch(textBoxEscrever.Text))
            {
                textBoxNormal.BackgroundImage = Properties.Resources.txtBoxEnterValue;
                if (gerouErro)
                {
                    //textBoxEscrever.Location = new Point(textBoxEscrever.Location.X - 30, textBoxEscrever.Location.Y);
                    gerouErro = false;
                }
            } else
            {
                textBoxEscrever_Error();
                //textBoxEscrever.Location = new Point(textBoxEscrever.Location.X + 30, textBoxEscrever.Location.Y);
            }
        }

        private void textBoxEscrever_DoubleClick(object sender, EventArgs e)
        {
            textBoxEscrever.Text = "";
        }

        // OUTROS MÉTODOS
        public void textBoxEscrever_Error()
        {
            gerouErro = true;
            textBoxNormal.BackgroundImage = Properties.Resources.txtBoxError3;
        }

        // GETTERS E SETTERS
        public string Texto {
            get { return textBoxEscrever.Text; }
            set { textBoxEscrever.Text = value; }
        }

        private void textBoxEscrever_TextChanged(object sender, EventArgs e)
        {

            if (!textBoxEscrever.Text.Equals("") && textBoxEscrever.Text.Length >= 4 && r.IsMatch(textBoxEscrever.Text))
            {
                textBoxNormal.BackgroundImage = Properties.Resources.txtBoxEnterValue;
            }
        }
    }
}
