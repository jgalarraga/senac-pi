using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lojinha
{
    public partial class TextBoxGrandeUserControl : UserControl
    {
        // ATRIBUTOS
        private Regex r = new Regex("[^A-Z0-9~.$ ]$"); // caracteres permitidos para input ao usuário
        private bool gerouErro = false;

        public TextBoxGrandeUserControl()
        {
            InitializeComponent();
        }

        private void textBoxEscrever_MouseDown(object sender, MouseEventArgs e)
        {
            // se gerou erro e não saiu disso
            if (gerouErro)
            {
                // tem que continuar gerando erro
                textBoxEscrever_Error();
            }
            else
            {
                textBox.BackgroundImage = Properties.Resources.txtBoxFocus;
            }
        }

        private void textBoxEscrever_Leave(object sender, System.EventArgs e)
        {
            textBox.BackgroundImage = Properties.Resources.txtBoxBasic;
        }

        private void textBoxEscrever_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBoxEscrever.Text.Length >= 4 && r.IsMatch(textBoxEscrever.Text))
            {
                textBox.BackgroundImage = Properties.Resources.txtBoxEnterValue;
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
        public void textBoxEscrever_Error()
        {
            gerouErro = true;
            textBox.BackgroundImage = Properties.Resources.txtBoxError;
        }

        private void textBoxEscrever_DoubleClick(object sender, System.EventArgs e)
        {
            textBoxEscrever.Text = "";
        }

        // GETTERS E SETTERS
        public override string Text
        {
            get { return textBoxEscrever.Text; }
            set { this.textBoxEscrever.Text = value; }
        }
    }
}
