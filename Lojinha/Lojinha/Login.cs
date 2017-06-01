using BancoModel;
using System;
using System.Windows.Forms;

namespace Lojinha
{
    public partial class Login : Form
    {
<<<<<<< HEAD
        // sem o static, não consigo acessar no outro form ;A; não sei o por quê
        public static string tipoUsuario { get; set; }

        public Login()
        {
            InitializeComponent();
            senhaTextBox.PasswordChar = '*';
            loginErrorPanel.Visible = false;
            cryImagePanel.Visible = false;
=======
        public Login()
        {
            InitializeComponent();
>>>>>>> 3b95b64970949f7a702db7382e92321347b5e16e
        }

        // MÉTODOS
        private void loginBtn_Click(object sender, EventArgs e)
        {
            clsUsuario usuario = new clsUsuario();

            // variável userCount recebe o retorno do método efetuarLogin que está na classe clsUsuario
            // se um registro for encontrado, a classe retorna 1
            // senão, retorna 0
<<<<<<< HEAD
            int userCount = usuario.validarLogin(usuarioTextBox.Text, senhaTextBox.Text);

=======
            int userCount = usuario.efetuarLogin(usuarioTextBox.Text, senhaTextBox.Text);
   
>>>>>>> 3b95b64970949f7a702db7382e92321347b5e16e
            if (userCount > 0)
            {
                // usuário existe no banco
                MessageBox.Show("Usuário Encontrado! Yay :3");
<<<<<<< HEAD
                tipoUsuario = usuario.selecionarTipoPerfil(usuarioTextBox.Text, senhaTextBox.Text);

                TelaPrincipal tp = new TelaPrincipal();
                tp.Show();

            }
            else
            {
                // usuário não existe no banco
                //MessageBox.Show("Usuário não encontrado! :/");
                loginErrorPanel.Visible = true;
                cryImagePanel.Visible = true;
            }
        }

        private void usuarioTextBox_TextChanged(object sender, EventArgs e)
        {
            loginErrorPanel.Visible = false;
            cryImagePanel.Visible = false;
        }
=======
            } else
            {
                // usuário não existe no banco
                MessageBox.Show("Usuário não encontrado! :/");
            }
        }
>>>>>>> 3b95b64970949f7a702db7382e92321347b5e16e
    }
}
