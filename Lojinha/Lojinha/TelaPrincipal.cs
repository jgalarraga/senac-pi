using BancoModel;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * Autores: João Lucas & Juliana Galarraga
 * Data: 
 * */

namespace Lojinha
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();

            adicionarProdutoBtn2.Visible = false;

            string tipoPerfil = Login.tipoUsuario;

            // se o usuário não for administrador
            if (!tipoPerfil.Equals("A"))
            {
                // bloqueio os formulários
                // e exibo uma mensagem
                adicionarProdutoBtn2.Visible = true;
                visualizarProdutosBtn2.Visible = true;
                visualizarClientesBtn2.Visible = true;
                criarUsuarioBtn2.Visible = true;
                visualizarPedidosBtn2.Visible = true;
                adicionarCategoriaBtn2.Visible = true;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // fecha a aplicação quando o usuário clica no "x" (canto superior direito da tela)
        private void exitBtn_Click(object sender, EventArgs e)
        {
            // cria um objeto do tipo "CaixaDeMensagem" (formulário) com a string assada por parâmetro
            CaixaDeMensagem messageBox = new CaixaDeMensagem("Você quer mesmo fechar a aplicação?");
            // mostra a caixa de mensagem ao usuário
            messageBox.Show();        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // minimiza a aplicação quando o usuário clica no "[]" (canto superior direito da tela)
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // maximiza a aplicação quando o usuário clica no "[]" (canto superior direito da tela)
        private void maximizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            normalSizeButton.Visible = true;
        }

        // abre o formulário "Adicionar Produto"
        private void addProductButton_Click(object sender, EventArgs e)
        {
            AdicionarProduto ap = new AdicionarProduto();
            ap.Show();
        }

        // abre o formulário "Visualizar Estoque"
        private void viewStorageButton_Click(object sender, EventArgs e)
        {
            VisualizarEstoque ve = new VisualizarEstoque();
            ve.Show();
        }

        private void addPaymentButton_Click(object sender, EventArgs e)
        {
            AdicionarFormaPagamento afp = new AdicionarFormaPagamento();
            afp.Show();
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            CriarUsuario cru = new CriarUsuario();
            cru.Show();
        }

        private void viewClientsButton_Click(object sender, EventArgs e)
        {
            VisualizarClientes vc = new VisualizarClientes();
            vc.Show();
        }

        private void viewOrdersButton_Click(object sender, EventArgs e)
        {
            VisualizarClientes vp = new VisualizarClientes();
            vp.Show();
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            AdicionarCategoria ac = new AdicionarCategoria();
            ac.Show();
        }

        private void visualizarEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizarEstoque ve = new VisualizarEstoque();
            ve.Show();
        }

        // abre o formulário "Status de Pedido" quando o usuário clica nesta opção
        private void adicionarStatusDePedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusDePedido sdp = new StatusDePedido();
            sdp.Show();
        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CriarUsuario cru = new CriarUsuario();
            cru.Show();
        }

        private void versãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void helpButton_Click(object sender, EventArgs e)
        {
            // deixa o botão de ajuda invisível
            retroGirlImage.Visible = true;
            await Task.Delay(4000);
            helpBalloon2.Visible = true;
            await Task.Delay(1000);
            closeButton.Visible = true;

        }

        private void retroGirlImage_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void helpBalloon2_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            closeButton.Visible = false;
            retroGirlImage.Visible = false;
            helpBalloon2.Visible = false;
        }

        private void adicionarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarCategoria ac = new AdicionarCategoria();
            ac.Show();
        }

        private void adicionarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarProduto ap = new AdicionarProduto();
            ap.Show();
        }

        private void normalSizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            normalSizeButton.Visible = false;
        }

        private void visualizarEstoqueBtn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você não tem permissão para adicionar produtos da loja.");
        }

        private void visualizarClientesBtn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você não tem permissão para acessar visualizar os clientes da loja.");
        }

        private void visualizarProdutosBtn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você não tem permissão para acessar visualizar os produtos da loja.");
        }

        private void criarUsuarioBtn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você não tem permissão para criar usuários.");
        }

        private void visualizarPedidosBtn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você não tem permissão para visualizar os pedidos da loja.");
        }

        private void adicionarCategoriaBtn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você não tem permissão para adicionar categorias.");
        }
    }
}
