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
    public partial class Menu : Form
    {
        //Variável _objForm é para controlar as propriedade dos forms
        private Form formulario = null;

        public Menu(Form formulario)
        {
            InitializeComponent();
            menuStrip.Location = new Point(menuStrip.Location.X, menuStrip.Location.Y + 30);
            this.formulario = formulario;

            this.painel.Size = new Size(formulario.Width, formulario.Height);
            this.painel.Location = new Point(
                 this.ClientSize.Width / 2 - painel.Size.Width / 2,
                (this.ClientSize.Height / 2 - painel.Size.Height / 2) + 60);
            this.painel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.painel.Controls.Add(formulario);
            formulario.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // cria um objeto do tipo "CaixaDeMensagem" (formulário) com a string assada por parâmetro
            CaixaDeMensagem messageBox = new CaixaDeMensagem("Você quer mesmo fechar a aplicação?");
            // mostra a caixa de mensagem ao usuário
            messageBox.Show();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void addProdutoButton_Click(object sender, EventArgs e)
        {
            formulario?.Close();//Se a variável _objForm estiver ocupada(com algum form aberto), será fechado.
            //Se não.
            formulario = new AdicionarProduto
            {
                TopLevel = false, //TopLevel = false, para que respeite o tamanho do Panel
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            this.painel.Size = new Size(formulario.Width, formulario.Height);
            this.painel.Location = new Point(
                 this.ClientSize.Width / 2 - painel.Size.Width / 2,
                (this.ClientSize.Height / 2 - painel.Size.Height / 2) + 60);
            this.painel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.painel.Controls.Add(formulario);
            formulario.Show();
            //
            //pnInicioSistemaRecebeDecisoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            //
        }
    }
}
