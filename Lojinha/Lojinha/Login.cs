using BancoModel;
using System;
using System.Windows.Forms;

namespace Lojinha
{
    public partial class Login : Form
    {
        // sem o static, não consigo acessar no outro form ;A; não sei o por quê
        public static string tipoUsuario { get; set; }

        public Login()
        {
            InitializeComponent();
            senhaTextBox.PasswordChar = '*';
            loginErrorPanel.Visible = false;
            cryImagePanel.Visible = false;
        }

        // MÉTODOS
        private void loginBtn_Click(object sender, EventArgs e)
        {
            clsUsuario usuario = new clsUsuario();

            // variável userCount recebe o retorno do método efetuarLogin que está na classe clsUsuario
            // se um registro for encontrado, a classe retorna 1
            // senão, retorna 0
            int userCount = usuario.validarLogin(usuarioTextBox.Text, senhaTextBox.Text);

            if (userCount > 0)
            {
                // usuário existe no banco
                //MessageBox.Show("Usuário Encontrado! Yay :3");
                tipoUsuario = usuario.selecionarTipoPerfil(usuarioTextBox.Text, senhaTextBox.Text);

                //TelaPrincipal tp = new TelaPrincipal();
                //tp.Show();
                TelaPrincipal tp = new TelaPrincipal();
                this.Hide();
                tp.ShowDialog();
                this.Close();
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

    }
}
