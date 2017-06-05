using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lojinha
{
    public partial class TextBoxMuitoPequenaUserControl : TextBoxGrandeUserControl
    {
        // ATRIBUTOS
        private Regex r = new Regex("[^A-Z0-9~.$ ]$"); // caracteres permitidos para input ao usuário
        private bool gerouErro = false;

        public TextBoxMuitoPequenaUserControl()
            :base()
        {
            InitializeComponent();
            this.textBox.BackgroundImage = Properties.Resources.txtBoxTiny;
            this.textBoxEscrever.Size = new Size(textBoxEscrever.Width - 230, textBoxEscrever.Height);
            this.textBoxEscrever.Location = new Point(textBoxEscrever.Location.X + 120, textBoxEscrever.Location.Y);
        }

        private void textBoxEscrever_MouseDown(object sender, MouseEventArgs e)
        {
            if (gerouErro)
            {
                textBoxEscrever_Error();
            }
            else
            {
                this.textBox.BackgroundImage = Properties.Resources.txtBoxFocusTiny;
            }
        }

        private void textBoxEscrever_Leave(object sender, EventArgs e)
        {
            this.textBox.BackgroundImage = Properties.Resources.txtBoxTiny;
        }

        private void textBoxEscrever_Validating(object sender, CancelEventArgs e)
        {
            if (r.IsMatch(textBoxEscrever.Text))
            {
                this.textBox.BackgroundImage = Properties.Resources.txtBoxEnterValueTiny;
                if (gerouErro)
                {
                    gerouErro = false;
                }
            }
            else
            {
                textBoxEscrever_Error();
            }
        }

        // OUTROS MÉTODOS
        public new void textBoxEscrever_Error()
        {
            gerouErro = true;
            textBox.BackgroundImage = Properties.Resources.txtBoxErrorTiny;
        }
    }
}
