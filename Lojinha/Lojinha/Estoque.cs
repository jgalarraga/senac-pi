using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BancoModel;
using System.Data;
using System.Data.SqlClient;

namespace Lojinha
{
    public partial class Estoque : Form
    {
        /* ATRIBUTOS */
        private List<clsCategoria> categorias;

        /* CONSTRUTOR */
        public Estoque()
        {
            InitializeComponent();
            List<clsEstoque> estoque = clsEstoque.SelecionarEstoque();
            EstoqueDataGridView.DataSource = estoque;
            // preenche o comboBox de categorias
            categorias = clsCategoria.SelecionarCategorias();
            //preencher a combobox com os dados da tabela Categoria que está no banco
            categoriaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoriaComboBox.DataSource = categorias;
            //nome do campo que representa a identificação (ID)de cada item do combobox
            categoriaComboBox.ValueMember = "idCategoria";
            //texto que será mostrado na combobox (que no caso serão os registros que estão na coluna "nomeCategoria")
            categoriaComboBox.DisplayMember = "nomeCategoria";
        }

        /* OUTROS MÉTODOS */
        // deixo a gridview deselecionada quando o usuário abre o formulário pela primeira vez
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            EstoqueDataGridView.Rows[0].Selected = false;
            // deixo a combobox em branco
            categoriaComboBox.SelectedIndex = -1;
            categoriaComboBox.Text = "<selecione uma categoria..>";
            // deixo a coluna do id invisível
            EstoqueDataGridView.Columns[0].Visible = false;
            // organizo as colunas da forma que eu quero
            ajustarOrdemColunas();
            renomearCabecalhoColunas();
        }

        private void ajustarOrdemColunas()
        {
            EstoqueDataGridView.Columns["nomeProduto"].DisplayIndex = 1;
            EstoqueDataGridView.Columns["qtdProdutoDisponivel"].DisplayIndex = 2;
            EstoqueDataGridView.Columns["nomeCategoria"].DisplayIndex = 3;
        }

        private void renomearCabecalhoColunas()
        {
            EstoqueDataGridView.Columns["nomeProduto"].HeaderText = "Produto";
            EstoqueDataGridView.Columns["qtdProdutoDisponivel"].HeaderText = "Quantidade";
            EstoqueDataGridView.Columns["nomeCategoria"].HeaderText = "Categoria";
        }

        // aqui uso o evento CellClick ao invés do SelectionChanged, porque não quero que quando o usuário abra o formulário
        // ele já esteja preenchido
        private void EstoqueDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (EstoqueDataGridView.SelectedRows.Count > 0)
            {
                //preencher as textbox com os dados vindos da tabela Estoque
                nomeProdTextBox.Text = EstoqueDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                QtdTextBox.Text = EstoqueDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                categoriaComboBox.Text = EstoqueDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        // quando o usuário clica na textbox do nome, a datagridview é deselecionada
        // e o usuário pode digitar qualquer coisa
        private void nomeProdTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            EstoqueDataGridView.ClearSelection();

        }


        private void pesqEstoqueButton_Click(object sender, EventArgs e)
        {
            List<clsEstoque> estoque = clsEstoque.SelecionarEstoque(nomeProdTextBox, categoriaComboBox);
            EstoqueDataGridView.DataSource = estoque;
        }

        private void nomeProdTextBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            nomeProdTextBox.Text = "";
            QtdTextBox.Text = "";
            // deixo a combobox em branco
            categoriaComboBox.SelectedIndex = -1;
            categoriaComboBox.Text = "<selecione uma categoria..>";
        }
    }
}
