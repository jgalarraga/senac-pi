using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lojinha
{
    public partial class CaixaDeMensagem : Form
    {

        public CaixaDeMensagem(string labelText)
        {
            InitializeComponent();
            alertMessage.Text = labelText;
        }

        private void CaixaDeMensagem_Load(object sender, EventArgs e)
        {

        }

        // Botões "Sim" e "Não"
        public void noButton_Click(object sender, EventArgs e)
        {
            // fecha a caixa de mensagem
            this.Close();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            // fecha a aplicação
            Application.Exit();
        }

        // ..... 
        private void alertMessage_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
