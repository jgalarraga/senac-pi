using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BancoModel;

namespace Lojinha
{
    public partial class AdicionarCategoria : Form
    {
        public AdicionarCategoria()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Tira a seleção do datagridview e de qualquer outro controle no primeiro momento
        /// </summary>
        private void AdicionarCategoria_Shown(object sender, EventArgs e)
        {
            // não deixo controles ativos no primeiro momento
            this.ActiveControl = null;
        }

        /// <summary>
        /// Tira a seleção do datagridview e de qualquer outro controle quando o usuário clica fora do datagridview, ou seja, na tela
        /// </summary>
        private void AdicionarCategoria_Click(object sender, EventArgs e)
        {
            // quando o usuário clica fora do data grid view
            // não deixo controles ativos no primeiro momento
            this.ActiveControl = null;
            // deixo o nome da categoria em branco
            nomeCategoriaTextBox.Text = "";
            // deixo a descrição em branco
            descCatProdTxtBox.Text = "";
            // deixo a data grid view deselecionada
            try
            {
                categoriaDataGridView.Rows[0].Selected = false;
            } catch (System.ArgumentOutOfRangeException ex)
            {
                // entra aqui quando o usuário clica fora da tela e não há nada no gridview
            }
        }

        /// <summary>
        /// mostra a listagem de categorias
        /// </summary>
        private void visualizarCategorias_Click(object sender, EventArgs e)
        {
            List<clsCategoria> categorias = clsCategoria.SelecionarCategorias();
            categoriaDataGridView.DataSource = categorias;
            configurarColunas();
            // já que o usuário ainda não clicou em nada
            // deixo o nome da categoria em branco
            nomeCategoriaTextBox.Text = "";
            // deixo o data grid view deselecionado
            categoriaDataGridView.Columns[0].Visible = false;
            categoriaDataGridView.Rows[0].Selected = false;
        }

        /// <summary>
        /// Configura tamanho e nome das colunas
        /// </summary>
        public void configurarColunas()
        {
            categoriaDataGridView.Columns[1].Width = 150;
            categoriaDataGridView.Columns[2].Width = 350;
            categoriaDataGridView.Columns[1].HeaderText = "Nome";
            categoriaDataGridView.Columns[2].HeaderText = "Descrição";
        }

        /// <summary>
        /// código executado quando o usuário clica no botão "adicionar"
        /// </summary>
        private void addCatProdButton_Click(object sender, EventArgs e)
        {
            // crio um objeto do tipo Categoria
            clsCategoria categoria = new clsCategoria();
            // faço com que os campos recebam o que for digitado nas text boxs
            categoria.nomeCategoria = this.nomeCategoriaTextBox.Text;
            if(categoria.nomeCategoria == "")
            {
                MessageBox.Show("Favor preencher o nome da categoria");
                return;
            }
            categoria.descCategoria = this.descCatProdTxtBox.Text;
            // chamo o método salvar da classe clsCategoria        
            categoria.Salvar();
            // atualizo a lista de categorias
            List<clsCategoria> categorias = clsCategoria.SelecionarCategorias();
            categoriaDataGridView.DataSource = categorias;
            categoriaDataGridView.Refresh();
            MessageBox.Show("Categoria adicionada com sucesso !");
        }

        /// <summary>
        /// Colore a textbox quando o usuário tira o foco dela
        /// </summary>
        private void nomeCategoriaTextBox_Leave(object sender, EventArgs e)
        {
            // se o usuário tiver preenchido a text box com alguma coisa... 
            if(!nomeCategoriaTextBox.Text.Equals(""))
            {
                nomeCategoriaTextBox.BackColor = System.Drawing.Color.LightYellow;
            }
        }

        private void categoriaDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (categoriaDataGridView.SelectedRows.Count > 0)
            {
                nomeCategoriaTextBox.Text = categoriaDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                if (categoriaDataGridView.SelectedRows[0].Cells[2].Value != null)
                {
                    descCatProdTxtBox.Text = categoriaDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                }

            }
        }

        private void altCatProdButton_Click(object sender, EventArgs e)
        {
            // crio um objeto do tipo Categoria
            clsCategoria categoria = new clsCategoria();
            if (this.nomeCategoriaTextBox.Text == "")
            {
                MessageBox.Show("Favor preencher o nome da categoria");
                return;
            }
            //funcao do demo para converter objeto em inteiro
            int id = (int)Convert.ChangeType(categoriaDataGridView.SelectedRows[0].Cells[0].Value, typeof(int));
            // Faço com que o idCategoria receba o valor do id da linha selecionada
            categoria.idCategoria = id;
            // faço com que os campos recebam o que for digitado nas text boxs
            categoria.nomeCategoria = this.nomeCategoriaTextBox.Text;
            categoria.descCategoria = this.descCatProdTxtBox.Text;
            // chamo o método salvar da classe clsCategoria
            categoria.Salvar();
            // atualizo a lista de categorias
            List<clsCategoria> categorias = clsCategoria.SelecionarCategorias();
            categoriaDataGridView.DataSource = categorias;
            categoriaDataGridView.Refresh();
            MessageBox.Show("Categoria alterada com sucesso !");
        }

        private void excCatProdButton_Click(object sender, EventArgs e)
        {
            //funcao do demo para converter objeto em inteiro
            int id = (int)Convert.ChangeType(categoriaDataGridView.SelectedRows[0].Cells[0].Value, typeof(int));
            // crio um objeto do tipo Categoria
            clsCategoria categoria = new clsCategoria();
            // Faço com que o idCategoria receba o valor do id da linha selecionada
            categoria.idCategoria = id;
            //chamo a função de excluir
            categoria.Excluir();
            List<clsCategoria> categorias = clsCategoria.SelecionarCategorias();
            categoriaDataGridView.DataSource = categorias;
            categoriaDataGridView.Refresh();
            MessageBox.Show("Categoria excluída com sucesso !");
        }
    }
}
