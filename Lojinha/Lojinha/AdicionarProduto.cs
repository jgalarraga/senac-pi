using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BancoModel;

namespace Lojinha
{
    public partial class AdicionarProduto : Form
    {
        public AdicionarProduto()
        {
            InitializeComponent();
            // preenche o dataGridView
            List<clsProduto> produtos = clsProduto.SelecionarProdutos();
            produtoDataGrid.DataSource = produtos;
            // preenche o comboBox de categorias
            List<clsCategoria> categorias = clsCategoria.SelecionarCategorias();
            CategoriaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoriaComboBox.DataSource = categorias;
                //NOME DO CAMPO QUE REPRESENTA A IDENTIFICAÇÃO DE CADA ITEM DO COMBOBOX
            CategoriaComboBox.ValueMember = "idCategoria";
                //TEXTO QUE SERÁ MOSTRADO NO COMBOBOX
            CategoriaComboBox.DisplayMember = "nomeCategoria";
        }


        // fecha a janela quando o usuário clica no "x" (canto superior direito da tela)
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // crio um objeto do tipo Produto
            clsProduto produto = new clsProduto();
            // faço com que os campos recebam o que for digitado nas text boxs
            produto.nomeProduto = this.nomeProdTextBox.Text;
            produto.descProduto = this.descProdTextBox.Text;
            produto.precProduto = (decimal)Convert.ChangeType(this.precoTextBox.Text, typeof(decimal));
            produto.descontoPromocao = (decimal)Convert.ChangeType(this.descontoTextBox.Text, typeof(decimal));
            produto.IdCategoria = (int)Convert.ChangeType(CategoriaComboBox.SelectedValue, typeof(int));
            produto.qtdMinEstoque = (int)Convert.ChangeType(this.qntMinTextBox.Text, typeof(int));
            produto.ativoProduto = "1";
            produto.IdUsuario = 1;
            // chamo o método salvar da classe clsCategoria
            produto.Salvar();
            //atualizo a lista de Produtos
            List<clsProduto> produtos = clsProduto.SelecionarProdutos();
            produtoDataGrid.DataSource = produtos;
            produtoDataGrid.Refresh();
            //MessageBox.Show((string)Convert.ChangeType(CategoriaComboBox.SelectedValue, typeof(string)));
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            //funcao do demo para converter objeto em inteiro
            int id = (int)Convert.ChangeType(produtoDataGrid.SelectedRows[0].Cells[0].Value, typeof(int));
            // crio um objeto do tipo Categoria
            clsProduto produto = new clsProduto();
            // Faço com que o idProduto receba o valor do id da linha selecionada
            produto.idProduto = id;
            // faço com que os campos recebam o que for digitado nas text boxs
            // chamo o método salvar da classe clsCategoria
            produto.Salvar();
            // atualizo a lista de categorias
            List<clsProduto> produtos = clsProduto.SelecionarProdutos();
            produtoDataGrid.DataSource = produtos;
            produtoDataGrid.Refresh();
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            //funcao do demo para converter objeto em inteiro
            int id = (int)Convert.ChangeType(produtoDataGrid.SelectedRows[0].Cells[0].Value, typeof(int));
            // crio um objeto do tipo Categoria
            clsProduto produto = new clsProduto();
            // Faço com que o idProduto receba o valor do id da linha selecionada
            produto.idProduto = id;
            //chamo a função de excluir
            produto.Excluir();
            List<clsProduto> produtos = clsProduto.SelecionarProdutos();
            produtoDataGrid.DataSource = produtos;
            produtoDataGrid.Refresh();
        }

        private void filtrarButton_Click(object sender, EventArgs e)
        {
            // preenche o dataGridView
            List<clsProduto> produtos = clsProduto.SelecionarProdutos(categoryComboBox.Text, comboBox1.Text);
            produtoDataGrid.DataSource = produtos;
            // preenche o comboBox de categorias
            List<clsCategoria> categorias = clsCategoria.SelecionarCategorias();
            CategoriaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoriaComboBox.DataSource = categorias;
            //NOME DO CAMPO QUE REPRESENTA A IDENTIFICAÇÃO DE CADA ITEM DO COMBOBOX
            CategoriaComboBox.ValueMember = "idCategoria";
            //TEXTO QUE SERÁ MOSTRADO NO COMBOBOX
            CategoriaComboBox.DisplayMember = "nomeCategoria";
        }

        private void produtoDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (produtoDataGrid.SelectedRows.Count > 0)
            {
                nomeProdTextBox.Text = produtoDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                descProdTextBox.Text = produtoDataGrid.SelectedRows[0].Cells[2].Value.ToString();
                precoTextBox.Text = produtoDataGrid.SelectedRows[0].Cells[3].Value.ToString();
                descontoTextBox.Text = produtoDataGrid.SelectedRows[0].Cells[4].Value.ToString();
                qntMinTextBox.Text = produtoDataGrid.SelectedRows[0].Cells[8].Value.ToString();
                CategoriaComboBox.Text = produtoDataGrid.SelectedRows[0].Cells[9].Value.ToString();
                if ((string)produtoDataGrid.SelectedRows[0].Cells[6].Value == "1")
                {
                    ativoComboBox.Text = "Ativo";
                }
                else
                {
                    ativoComboBox.Text = "Desativado";
                }
            }
        }
    }
 }

