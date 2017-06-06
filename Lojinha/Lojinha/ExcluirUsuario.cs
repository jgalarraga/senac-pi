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
    public partial class ExcluirUsuario : Form
    {
        public ExcluirUsuario()
        {
            InitializeComponent();
            inicializarUserControls();
        } 

        private void inicializarUserControls()
        {
            TextBoxPequenaUserControl loginTextBox = new TextBoxPequenaUserControl();
            TextBoxPequenaUserControl senhaTextBox = new TextBoxPequenaUserControl();
            TextBoxPequenaUserControl senhaTextBox2 = new TextBoxPequenaUserControl();
        }
        private void excUsuarioButton_Click(object sender, EventArgs e)
        {
            if (senhaTextBox.Text.Equals(senhaTextBox2.Text))
            {
                clsUsuario usuario = new clsUsuario();
                if(loginTextBox.Text == "" && senhaTextBox.Text == "")
                {
                    MessageBox.Show("Favor preencher todos os campos");
                    return;
                }
                // valido o login
                // variável userCount recebe o retorno do método efetuarLogin que está na classe clsUsuario
                // se um registro for encontrado, a classe retorna 1
                // senão, retorna 0
                int userCount = usuario.validarLogin(loginTextBox.Text, senhaTextBox.Text);

                // se for válido
                if (userCount > 0)
                {
                    // deixo o usuário excluir
                    usuario.Excluir(loginTextBox.Text);
                    MessageBox.Show("Usuário excluído com sucesso");
                }
                else
                {
                    // senão, não permito
                    loginTextBox.textBoxEscrever_Error();
                }
            }else
            {
                MessageBox.Show("As senhas diferem");
            }
        }


    }
}
