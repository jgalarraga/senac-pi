using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lojinha
{
    public partial class TextBoxPequenaUserControl : TextBoxGrandeUserControl
    {
        // ATRIBUTOS
        private Regex r = new Regex("[^A-Z0-9~.$ ]$"); // caracteres permitidos para input ao usuário
        private bool gerouErro = false;

        public TextBoxPequenaUserControl()
            :base()
        {
            InitializeComponent();
            this.textBox.BackgroundImage = Properties.Resources.txtBoxSmall;
            this.textBoxEscrever.Size = new Size(textBoxEscrever.Width - 150, textBoxEscrever.Height);
            this.textBoxEscrever.Location = new Point(textBoxEscrever.Location.X + 80, textBoxEscrever.Location.Y);
        }

        private void textBoxEscrever_MouseDown(object sender, MouseEventArgs e)
        {
            if (gerouErro)
            {
                textBoxEscrever_Error();
            }
            else
            {
                this.textBox.BackgroundImage = Properties.Resources.txtBoxFocusSmall;
            }
        }

        private void textBoxEscrever_Leave(object sender, EventArgs e)
        {
            this.textBox.BackgroundImage = Properties.Resources.txtBoxSmall;
        }

        private void textBoxEscrever_Validating(object sender, CancelEventArgs e)
        {
            if (r.IsMatch(textBoxEscrever.Text))
            {
                this.textBox.BackgroundImage = Properties.Resources.txtBoxEnterValueSmall;
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
            textBox.BackgroundImage = Properties.Resources.txtBoxErrorSmall;
        }
    }
}
