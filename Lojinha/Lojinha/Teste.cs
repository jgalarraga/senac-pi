using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BancoModel;
namespace Lojinha
{
    public partial class Teste : Form
    {
        public Teste()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<clsCliente> Clientes = clsCliente.SelecionarClientes();
            foreach (clsCliente C in Clientes)
                MessageBox.Show(C.nomeCompletoCliente);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<clsProduto> Produtos = clsProduto.SelecionarProdutos();
            foreach (clsProduto P in Produtos)
                MessageBox.Show(P.nomeProduto);
        }
    }
}
