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

            label1.Text = Login.nomeUsuario;
            
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
            configurarFormulario(formulario);
        }

        private void visualizarProdutos_Click(object sender, EventArgs e)
        {
            formulario?.Close();//Se a variável _objForm estiver ocupada(com algum form aberto), será fechado.
            //Se não.
            formulario = new AdicionarProduto
            {
                TopLevel = false, //TopLevel = false, para que respeite o tamanho do Panel
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            configurarFormulario(formulario);
        }

        private void removerUsuario_Click(object sender, EventArgs e)
        {
            formulario?.Close();//Se a variável _objForm estiver ocupada(com algum form aberto), será fechado.
            //Se não.
            formulario = new ExcluirUsuario
            {
                TopLevel = false, //TopLevel = false, para que respeite o tamanho do Panel
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            configurarFormulario(formulario);
        }

        private void adicionarCategoria_Click(object sender, EventArgs e)
        {
            formulario?.Close();//Se a variável _objForm estiver ocupada(com algum form aberto), será fechado.
            //Se não.
            formulario = new AdicionarCategoria
            {
                TopLevel = false, //TopLevel = false, para que respeite o tamanho do Panel
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            configurarFormulario(formulario);
        }

        private void visualizarClientes_Click(object sender, EventArgs e)
        {
            formulario?.Close();//Se a variável _objForm estiver ocupada(com algum form aberto), será fechado.
            //Se não.
            formulario = new VisualizarClientes
            {
                TopLevel = false, //TopLevel = false, para que respeite o tamanho do Panel
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            configurarFormulario(formulario);
        }

        private void criarUsuario_Click(object sender, EventArgs e)
        {
            formulario?.Close();//Se a variável _objForm estiver ocupada(com algum form aberto), será fechado.
            //Se não.
            formulario = new CadastroUsuario
            {
                TopLevel = false, //TopLevel = false, para que respeite o tamanho do Panel
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            configurarFormulario(formulario);
        }

        private void Estoque_Click(object sender, EventArgs e)
        {
            formulario?.Close();//Se a variável _objForm estiver ocupada(com algum form aberto), será fechado.
            //Se não.
            formulario = new Estoque
            {
                TopLevel = false, //TopLevel = false, para que respeite o tamanho do Panel
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            configurarFormulario(formulario);
        }

        // TOOLSTRIP
        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formulario?.Close();//Se a variável _objForm estiver ocupada(com algum form aberto), será fechado.
            //Se não.
            formulario = new CadastroUsuario
            {
                TopLevel = false, //TopLevel = false, para que respeite o tamanho do Panel
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            configurarFormulario(formulario);
        }

        private void excluirUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formulario?.Close();//Se a variável _objForm estiver ocupada(com algum form aberto), será fechado.
            //Se não.
            formulario = new ExcluirUsuario
            {
                TopLevel = false, //TopLevel = false, para que respeite o tamanho do Panel
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            configurarFormulario(formulario);
        }

        private void fazerLogoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
            this.Close();
        }

        private void adicionarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formulario?.Close();//Se a variável _objForm estiver ocupada(com algum form aberto), será fechado.
            //Se não.
            formulario = new AdicionarProduto
            {
                TopLevel = false, //TopLevel = false, para que respeite o tamanho do Panel
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            configurarFormulario(formulario);
        }

        public void configurarFormulario(Form formulario)
        {
            this.painel.Size = new Size(formulario.Width, formulario.Height);
            this.painel.Location = new Point(
                 this.ClientSize.Width / 2 - painel.Size.Width / 2,
                (this.ClientSize.Height / 2 - painel.Size.Height / 2) + 60);
            this.painel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.painel.Controls.Add(formulario);
            formulario.Show();
        }

        private void visualizarEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formulario?.Close();//Se a variável _objForm estiver ocupada(com algum form aberto), será fechado.
            //Se não.
            formulario = new Estoque
            {
                TopLevel = false, //TopLevel = false, para que respeite o tamanho do Panel
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            configurarFormulario(formulario);
        }

        private void cadastrarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formulario?.Close();//Se a variável _objForm estiver ocupada(com algum form aberto), será fechado.
            //Se não.
            formulario = new AdicionarCategoria
            {
                TopLevel = false, //TopLevel = false, para que respeite o tamanho do Panel
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            configurarFormulario(formulario);
        }

        private void visualizarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formulario?.Close();//Se a variável _objForm estiver ocupada(com algum form aberto), será fechado.
            //Se não.
            formulario = new VisualizarClientes
            {
                TopLevel = false, //TopLevel = false, para que respeite o tamanho do Panel
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            configurarFormulario(formulario);
        }

        private void logoffButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
            this.Close();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaPrincipal tp = new TelaPrincipal();
            tp.ShowDialog();
            this.Close();
        }

        private void Estoque_Click_1(object sender, EventArgs e)
        {
            formulario?.Close();//Se a variável _objForm estiver ocupada(com algum form aberto), será fechado.
            //Se não.
            formulario = new Estoque
            {
                TopLevel = false, //TopLevel = false, para que respeite o tamanho do Panel
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            configurarFormulario(formulario);
        }

        private void addProdutoButton_MouseEnter(object sender, EventArgs e)
        {
            addProdutosTip.Location = new Point(addProdutosTip.Location.X, menuStrip.Height - 95);
            addProdutosTip.Visible = true;
        }

        private void addProdutoButton_MouseLeave(object sender, EventArgs e)
        {
            addProdutosTip.Visible = false;
        }

        private void visualizarProdutos_MouseEnter(object sender, EventArgs e)
        {
            visualizarProdutosTip.Visible = true;
        }

        private void visualizarProdutos_MouseLeave(object sender, EventArgs e)
        {
            visualizarProdutosTip.Visible = false;
        }

        private void removerUsuario_MouseEnter(object sender, EventArgs e)
        {
            removerUsuarioTip.Visible = true;
        }

        private void removerUsuario_MouseLeave(object sender, EventArgs e)
        {
            removerUsuarioTip.Visible = false;
        }

        private void Estoque_MouseEnter(object sender, EventArgs e)
        {
            estoqueTip.Location = new Point(estoqueTip.Location.X, menuStrip.Height - 95);
            estoqueTip.Visible = true;
        }

        private void Estoque_MouseLeave(object sender, EventArgs e)
        {
            estoqueTip.Visible = false;
        }

        private void adicionarCategoria_MouseEnter(object sender, EventArgs e)
        {
            adicionarCategoriaTip.Location = new Point(adicionarCategoriaTip.Location.X, menuStrip.Height - 95);
            adicionarCategoriaTip.Visible = true;
        }

        private void adicionarCategoria_MouseLeave(object sender, EventArgs e)
        {
            adicionarCategoriaTip.Visible = false;
        }

        private void visualizarPedidos_MouseEnter(object sender, EventArgs e)
        {
            pedidosTip.Visible = true;
        }

        private void visualizarPedidos_MouseLeave(object sender, EventArgs e)
        {
            pedidosTip.Visible = false;
        }

        private void visualizarClientes_MouseEnter(object sender, EventArgs e)
        {
            visualizarClientesTip.Location = new Point(visualizarClientesTip.Location.X, menuStrip.Height - 95);
            visualizarClientesTip.Visible = true;
        }

        private void visualizarClientes_MouseLeave(object sender, EventArgs e)
        {
            visualizarClientesTip.Visible = false;
        }

        private void criarUsuario_MouseEnter(object sender, EventArgs e)
        {
            adicionarUsuarioTip.Visible = true;
        }

        private void criarUsuario_Leave(object sender, EventArgs e)
        {
            adicionarUsuarioTip.Visible = false;
        }
    }
}
