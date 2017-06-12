using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BancoModel;

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
        }

        private void Estoque_Shown(object sender, EventArgs e)
        {
            // já que o usuário ainda não clicou em nada
            // não deixo controles ativos no primeiro momento
            this.ActiveControl = null;
        }

        private void Estoque_Click(object sender, EventArgs e)
        {
            // já que o usuário ainda não clicou em nada
            // não deixo controles ativos no primeiro momento
            this.ActiveControl = null;
            // deixo as textBox em branco
            nomeProdTextBox.Text = "";
            QtdTextBox.Text = "";
            categoriaComboBox.SelectedIndex = -1;
            // deixo o data grid view deselecionado
            try
            {
                EstoqueDataGridView.Rows[0].Selected = false;
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                // entra aqui quando o usuário clica fora da tela no primeiro momento e não há nada no gridview
            }
        }

        /// <summary>
        /// botão visualizar estoque
        /// </summary>
        private void visualizarEstoque_Click(object sender, EventArgs e)
        {
            nomeProdTextBox.Text = "";
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
            // deixo a combobox em branco
            categoriaComboBox.SelectedIndex = -1;
            categoriaComboBox.Text = "<selecione uma categoria..>";

            // deixo a coluna do id invisível
            EstoqueDataGridView.Columns[0].Visible = false;
            // organizo as colunas da forma que eu quero
            ajustarOrdemColunas();
            renomearCabecalhoColunas();

            // deixo as textBox em branco
            categoriaComboBox.SelectedIndex = -1;
            // deixo o data grid view deselecionado
            EstoqueDataGridView.Rows[0].Selected = false;
        }

        /* OUTROS MÉTODOS */
        // deixo a gridview deselecionada quando o usuário abre o formulário pela primeira vez
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // esse trecho de código só vai gerar uma excessão quando a pesquisa retornar nada
            // ou seja, temos certeza de que quando essa excessão for gerada, é porque a pesquisa não retornou um resultado
            try
            {
                EstoqueDataGridView.Rows[0].Selected = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("A pesquisa não retornou resultados. :C");
            }                    
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
            List<clsEstoque> estoque = clsEstoque.SelecionarEstoque(nomeProdTextBox.Text, categoriaComboBox.Text);
            EstoqueDataGridView.DataSource = estoque;
        }

        private void nomeProdTextBox_DoubleClick(object sender, EventArgs e)
        {
            nomeProdTextBox.Text = "";
            QtdTextBox.Text = "";
            // deixo a combobox em branco
            categoriaComboBox.SelectedIndex = -1;
            categoriaComboBox.Text = "<selecione uma categoria..>";
        }

        private void alterarQuantidade_Click(object sender, EventArgs e)
        {
            // crio um objeto do tipo estoque
            clsEstoque est = new clsEstoque();

            if (this.nomeProdTextBox.Text == "")
            {
                MessageBox.Show("Escolha um produto para poder alterá-lo.");
                return;
            }

            if (int.Parse(this.QtdTextBox.Text) < 0)
            {
                MessageBox.Show("Quantidade inválida! Favor colocar um valor maior ou igual a zero na quantidade.");
                return;
            }

            est.idProduto = (int)Convert.ChangeType(EstoqueDataGridView.SelectedRows[0].Cells[0].Value, typeof(int));
            est.qtdProdutoDisponivel = (int)Convert.ChangeType(this.QtdTextBox.Text, typeof(int));

            // chamo o método salvar da classe clsCategoria
            est.Salvar();
            // atualizo a lista de categorias
            List<clsEstoque> estoque = clsEstoque.SelecionarEstoque();
            EstoqueDataGridView.DataSource = estoque;
            EstoqueDataGridView.Refresh();
            ajustarOrdemColunas();
            renomearCabecalhoColunas();
            MessageBox.Show("Quantidade alterada com sucesso !");

        }

        private void filtroComboBox_TextChanged(object sender, EventArgs e)
        {
            filtroTextBox.Visible = true;

            if (filtroComboBox.Text.Equals("Categoria") || filtroComboBox.Text.Equals("Nome&Categoria"))
            {
                categoriaComboBox.Visible = true;
                // preenche o comboBox de categorias
                List<clsCategoria> categorias = clsCategoria.SelecionarCategorias();
                categoriaComboBox.DataSource = categorias;
                //NOME DO CAMPO QUE REPRESENTA A IDENTIFICAÇÃO DE CADA ITEM DO COMBOBOX
                categoriaComboBox.ValueMember = "idCategoria";
                //TEXTO QUE SERÁ MOSTRADO NO COMBOBOX
                categoriaComboBox.DisplayMember = "nomeCategoria";
            }
            else
            {
                categoriaComboBox.Visible = false;
            }
        }

        private void filtroTextBox_TextChanged(object sender, EventArgs e)
        {
            List<clsEstoque> estoque;

            if (filtroComboBox.Text.Equals("Nome"))
            {
                estoque = clsEstoque.SelecionarEstoque(filtroTextBox.Text);
                EstoqueDataGridView.DataSource = estoque;
            }
            else if (filtroComboBox.Text.Equals("Nome&Categoria"))
            {
                estoque = clsEstoque.SelecionarEstoque(filtroTextBox.Text, categoriaComboBox.Text);
            }
            else
            {
                estoque = clsEstoque.SelecionarEstoque(filtroTextBox.Text);
                EstoqueDataGridView.DataSource = estoque;
            }
        }
    } 
}
