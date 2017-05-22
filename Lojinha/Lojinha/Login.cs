using BancoModel;
using System;
using System.Windows.Forms;

namespace Lojinha
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // MÉTODOS
        private void loginBtn_Click(object sender, EventArgs e)
        {
            clsUsuario usuario = new clsUsuario();

            // variável userCount recebe o retorno do método efetuarLogin que está na classe clsUsuario
            // se um registro for encontrado, a classe retorna 1
            // senão, retorna 0
            int userCount = usuario.efetuarLogin(usuarioTextBox.Text, senhaTextBox.Text);
   
            if (userCount > 0)
            {
                // usuário existe no banco
                MessageBox.Show("Usuário Encontrado! Yay :3");
            } else
            {
                // usuário não existe no banco
                MessageBox.Show("Usuário não encontrado! :/");
            }
        }
    }
}
