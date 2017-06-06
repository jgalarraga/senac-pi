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
            List<clsCategoria> categorias = clsCategoria.SelecionarCategorias();
            dataGridView1.DataSource = categorias;
            configurarColunas();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void configurarColunas()
        {
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 306;
            dataGridView1.Columns[1].HeaderText = "Nome";
            dataGridView1.Columns[2].HeaderText = "Descrição";
        }

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
            dataGridView1.DataSource = categorias;
            dataGridView1.Refresh();
            MessageBox.Show("Categoria adicionada com sucesso !");
        }

        /**
         *  Colore a textbox quando o usuário tira o foco dela
         * */
        private void nomeCategoriaTextBox_Leave(object sender, EventArgs e)
        {
            // se o usuário tiver preenchido a text box com alguma coisa... 
            if(!nomeCategoriaTextBox.Text.Equals(""))
            {
                nomeCategoriaTextBox.BackColor = System.Drawing.Color.LightYellow;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                nomeCategoriaTextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells[2].Value != null)
                {
                    descCatProdTxtBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                }

            }
        }

        private void altCatProdButton_Click(object sender, EventArgs e)
        {
            //funcao do demo para converter objeto em inteiro
            int id = (int)Convert.ChangeType(dataGridView1.SelectedRows[0].Cells[0].Value, typeof(int));
            // crio um objeto do tipo Categoria
            clsCategoria categoria = new clsCategoria();
            // Faço com que o idCategoria receba o valor do id da linha selecionada
            categoria.idCategoria = id;
            // faço com que os campos recebam o que for digitado nas text boxs
            categoria.nomeCategoria = this.nomeCategoriaTextBox.Text;
            categoria.descCategoria = this.descCatProdTxtBox.Text;
            // chamo o método salvar da classe clsCategoria
            categoria.Salvar();
            // atualizo a lista de categorias
            List<clsCategoria> categorias = clsCategoria.SelecionarCategorias();
            dataGridView1.DataSource = categorias;
            dataGridView1.Refresh();
            MessageBox.Show("Categoria alterada com sucesso !");
        }

        private void excCatProdButton_Click(object sender, EventArgs e)
        {
            //funcao do demo para converter objeto em inteiro
            int id = (int)Convert.ChangeType(dataGridView1.SelectedRows[0].Cells[0].Value, typeof(int));
            // crio um objeto do tipo Categoria
            clsCategoria categoria = new clsCategoria();
            // Faço com que o idCategoria receba o valor do id da linha selecionada
            categoria.idCategoria = id;
            //chamo a função de excluir
            categoria.Excluir();
            List<clsCategoria> categorias = clsCategoria.SelecionarCategorias();
            dataGridView1.DataSource = categorias;
            dataGridView1.Refresh();
            MessageBox.Show("Categoria excluída com sucesso !");
        }
    }
}
