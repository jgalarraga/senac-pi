using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BancoModel;
using System.IO;
using System.Drawing;

namespace Lojinha
{
    public partial class AdicionarProduto : Form
    {
        byte[] imagem;

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
            // deixo a coluna do id invisível
            produtoDataGrid.Columns[5].Visible = false;
            produtoDataGrid.Columns[6].Visible = false;
            produtoDataGrid.Columns[10].Visible = false;
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
            produto.imagem = (byte[])Convert.ChangeType(this.imagem, typeof(byte[]));
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

                if (produtoDataGrid.SelectedRows[0].Cells[10].Value != null)
                {
                    imagem = new byte[0];
                    imagem = (byte[])(produtoDataGrid.SelectedRows[0].Cells["Imagem"].Value);
                    mostraFoto(imagem);
                } 
            }
        }

        private void mostraFoto(byte[] dados)
        {
            if (dados.Length > 0)
            {
                MemoryStream mem = new MemoryStream(dados);
                try
                {
                    productPicture.Image = Image.FromStream(mem);
                } catch (System.ArgumentException e)
                {
                    // NOTA: TRATAR POSTERIORMENTE! 
                    // esta exceção ocorre quando a picturebox recebe imagens muitas vezes
                    // ou seja, quando o usuário fica clica em muitas linhas da gridview
                }
                mem.Dispose();
            }
            else
            {
                productPicture.Image = null;
            }
        }

        private void filtroComboBox_TextChanged(object sender, EventArgs e)
        {
            if(filtroComboBox.Text.Equals("Categoria"))
            {
                filtroComboBox2.Visible = true;
                comboBox2BG.Visible = true;
                filtroTextBox.Visible = false;
                // preenche o comboBox de categorias
                List<clsCategoria> categorias = clsCategoria.SelecionarCategorias();
                filtroComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
                filtroComboBox2.DataSource = categorias;
                //NOME DO CAMPO QUE REPRESENTA A IDENTIFICAÇÃO DE CADA ITEM DO COMBOBOX
                filtroComboBox2.ValueMember = "idCategoria";
                //TEXTO QUE SERÁ MOSTRADO NO COMBOBOX
                filtroComboBox2.DisplayMember = "nomeCategoria";
            } else
            {
                filtroTextBox.Visible = true;
                filtroComboBox2.Visible = false;
                comboBox2BG.Visible = false;
            }
        }

        private void limparFiltroButton_Click(object sender, EventArgs e)
        {
            // preenche o dataGridView
            List<clsProduto> produtos = clsProduto.SelecionarProdutos();
            produtoDataGrid.DataSource = produtos;

        }

        private void filtroTextBox_TextChanged(object sender, EventArgs e)
        {
            List<clsProduto> produtos;
            // preenche o dataGridView
            produtos = clsProduto.SelecionarProdutos(filtroComboBox.Text, filtroTextBox.Text);
            produtoDataGrid.DataSource = produtos;
        }

        private void filtroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<clsProduto> produtos;
            produtos = clsProduto.SelecionarProdutos(filtroComboBox.Text, filtroComboBox2.Text);
            produtoDataGrid.DataSource = produtos;
        }

        private void productPicture_MouseEnter(object sender, EventArgs e)
        {
            this.productPicture.BackgroundImage = Properties.Resources.photoAdd;
        }

        private void productPicture_MouseLeave(object sender, EventArgs e)
        {
            this.productPicture.BackgroundImage = Properties.Resources.noPhoto;
        }

        private void productPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivos de imagem (*.jpg)|*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.CheckFileExists)
                {
                    imagem = File.ReadAllBytes(ofd.FileName);
                    mostraFoto(imagem);
                }
                else
                {
                    imagem = new byte[0];
                    MessageBox.Show("Arquivo Inválido! :C Tente novamente...");
                }
            }
        }
    }
 }

