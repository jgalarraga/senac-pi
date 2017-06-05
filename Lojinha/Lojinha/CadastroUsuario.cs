using BancoModel;
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
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addUsuarioButton_Click(object sender, EventArgs e)
        {
            // se os dois campos de senha estiverem iguais
            if (senhaUsuarioTextBox.Text.Equals(senha2UsuarioTextBox.Text))
            {
                // crio um objeto do tipo Produto
                clsUsuario usuario = new clsUsuario();
                // faço com que os campos recebam o que for digitado nas text boxs
                usuario.loginUsuario = this.loginUsuarioTextBox.Text;
                usuario.nomeUsuario = this.nomeUsuarioTextBox.Text;
                usuario.senhaUsuario = this.senhaUsuarioTextBox.Text;
                usuario.tipoPerfil = this.perfilUsuarioTextBox.Text;
                // chamo o método salvar da classe clsUsuario
                usuario.Salvar();
            } else
            {
                //mostro um aviso ao usuário para que ele possa digitar a senha novamente
            }
        }
    }
}
