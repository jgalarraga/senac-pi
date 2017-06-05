using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lojinha
{
    public partial class TextBoxMediaUserControl : TextBoxGrandeUserControl
    {
        // ATRIBUTOS
        private Regex r = new Regex("[^A-Z0-9~.$ ]$"); // caracteres permitidos para input ao usuário
        private bool gerouErro = false;

        public TextBoxMediaUserControl()
            :base()
        {
            InitializeComponent();
            this.textBox.BackgroundImage = Properties.Resources.txtBoxMedium;
            this.textBoxEscrever.Size = new Size(textBoxEscrever.Width - 70, textBoxEscrever.Height);
            this.textBoxEscrever.Location = new Point(textBoxEscrever.Location.X + 40, textBoxEscrever.Location.Y);
        }

        private void textBoxEscrever_MouseDown(object sender, MouseEventArgs e)
        {
            if (gerouErro)
            {
                textBoxEscrever_Error();
            }
            else
            {
                this.textBox.BackgroundImage = Properties.Resources.txtBoxFocusMedium;
            }
        }

        private void textBoxEscrever_Leave(object sender, EventArgs e)
        {
            this.textBox.BackgroundImage = Properties.Resources.txtBoxMedium;
        }

        private void textBoxEscrever_Validating(object sender, CancelEventArgs e)
        {
            if (r.IsMatch(textBoxEscrever.Text))
            {
                this.textBox.BackgroundImage = Properties.Resources.txtBoxEnterValueMedium;
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
            textBox.BackgroundImage = Properties.Resources.txtBoxErrorMedium;
        }
    }
}
