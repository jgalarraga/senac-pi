using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BancoModel;

namespace Lojinha
{
    public partial class VisualizarClientes : Form
    {
        // crio um vetor de textboxes 
        //private textBoxUserControl[] textboxes; //vetor de user control obrigatórios
        private TextBoxGrandeUserControl[] textboxesGrandes;
        private TextBoxMediaUserControl[] textboxesMedias;
        private TextBoxPequenaUserControl[] textboxesPequenas;
        private TextBoxMuitoPequenaUserControl[] textboxesMuitoPequenas;

        public VisualizarClientes()
        {
            instanciarUserControls();

            InitializeComponent();
            // listagem dos clientes cadastrados
            List<clsCliente> clientes = clsCliente.SelecionarClientes();
            // mostro a listagem na grid view
            clienteDataGridView.DataSource = clientes;
            //Escondendo os campos indesejados do gridview, deixando só o nome do cliente
            esconderColunas();
            configurarColunas();

            // inicializo o vetor de textbox
            // com as textboxes obrigatórias
            textboxesGrandes = new TextBoxGrandeUserControl[]
            {
                nomeCadClienteTextBox,
                emailCadClienteTextBox,
                logradouroCadClienteTextBox
            };

            textboxesMedias = new TextBoxMediaUserControl[]
            {
                 cpfCadClienteTextBox,
            };

            textboxesPequenas = new TextBoxPequenaUserControl[]
            {
                 dtNascCadClienteTextBox,
                 senhaCadClienteTextBox,
                 tipoEndCadClienteTextBox,
                 cidadeEndCadClienteTextBox,
                 cepEndCadClienteTextBox
            };

            textboxesMuitoPequenas = new TextBoxMuitoPequenaUserControl[]
            {
                numEndCadClienteTextBox
            };


        }

        // MÉTODOS COMUNS
        // caso haja algum problema no carregamento dos user controls
        // através deste método consigo instanciá-los novamente no formulário
        public void instanciarUserControls()
        {
            // DADOS DO CLIENTE
            TextBoxGrandeUserControl nomeCadTxtBox = new TextBoxGrandeUserControl();
            TextBoxMediaUserControl cpfCadClienteTextBox = new TextBoxMediaUserControl();
            TextBoxPequenaUserControl dtNascCadClienteTextBox = new TextBoxPequenaUserControl();
            TextBoxGrandeUserControl emailCadClienteTextBox = new TextBoxGrandeUserControl();
            TextBoxPequenaUserControl senhaCadClienteTextBox = new TextBoxPequenaUserControl();
            TextBoxPequenaUserControl celularCadClienteTextBox = new TextBoxPequenaUserControl();
            TextBoxPequenaUserControl telResCadClienteTextBox = new TextBoxPequenaUserControl();
            TextBoxPequenaUserControl telComCadClienteTextBox = new TextBoxPequenaUserControl();

            // ENDEREÇO
            TextBoxPequenaUserControl tipoEndCadClienteTextBox = new TextBoxPequenaUserControl();
            TextBoxGrandeUserControl logradouroCadClienteTextBox = new TextBoxGrandeUserControl();
            TextBoxMuitoPequenaUserControl numEndCadClienteTextBox = new TextBoxMuitoPequenaUserControl();
            TextBoxPequenaUserControl cepEndCadClienteTextBox = new TextBoxPequenaUserControl();
            TextBoxMediaUserControl complEndCadClienteTextBox = new TextBoxMediaUserControl();
            TextBoxPequenaUserControl cidadeEndCadClienteTextBox = new TextBoxPequenaUserControl();
            TextBoxMuitoPequenaUserControl ufEndCadClienteTextBox = new TextBoxMuitoPequenaUserControl();
            TextBoxPequenaUserControl paisEndCadClienteTextBox = new TextBoxPequenaUserControl();
        }

        public void esconderColunas()
        {
            // DataGridView do nome do cliente
            clienteDataGridView.Columns[0].Visible = false;
            clienteDataGridView.Columns[2].Visible = false;
            clienteDataGridView.Columns[3].Visible = false;
            clienteDataGridView.Columns[4].Visible = false;
            clienteDataGridView.Columns[5].Visible = false;
            clienteDataGridView.Columns[6].Visible = false;
            clienteDataGridView.Columns[7].Visible = false;
            clienteDataGridView.Columns[8].Visible = false;
            clienteDataGridView.Columns[9].Visible = false;
        }

        public void configurarColunas()
        {
            clienteDataGridView.Columns[1].Width = 491;
            clienteDataGridView.Columns["nomeCompletoCliente"].HeaderText = "Nome do Cliente";
        }

        // EVENTOS
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clienteDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (clienteDataGridView.SelectedRows.Count > 0)
            {
                //colocando o valor nos txtBox
                nomeCadClienteTextBox.Text = clienteDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                cpfCadClienteTextBox.Text = clienteDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                if (clienteDataGridView.SelectedRows[0].Cells[5].Value != null)
                {
                    dtNascCadClienteTextBox.Text = clienteDataGridView.SelectedRows[0].Cells[8].Value.ToString();
                }
                emailCadClienteTextBox.Text = clienteDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                senhaCadClienteTextBox.Text = clienteDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                if (clienteDataGridView.SelectedRows[0].Cells[5].Value != null)
                {
                    celularCadClienteTextBox.Text = clienteDataGridView.SelectedRows[0].Cells[5].Value.ToString();
                }
                if (clienteDataGridView.SelectedRows[0].Cells[7].Value != null)
                {
                    telResCadClienteTextBox.Text = clienteDataGridView.SelectedRows[0].Cells[7].Value.ToString();
                }
                if (clienteDataGridView.SelectedRows[0].Cells[6].Value != null)
                {
                    telComCadClienteTextBox.Text = clienteDataGridView.SelectedRows[0].Cells[6].Value.ToString();
                }
                //adicionando os endereços no gridview dos endereço
                //List<clsEndereco> enderecos = clsEndereco.SelecionarEnderecos((int)Convert.ChangeType(textBox1.Text, typeof(int)));
                List<clsEndereco> enderecos = clsEndereco.SelecionarEnderecos(nomeCadClienteTextBox.Text);
                enderecoDataGridView.DataSource = enderecos;

                //DataGridView dos endereços do cliente
                enderecoDataGridView.Columns[0].Visible = false;
                enderecoDataGridView.Columns[1].Visible = false;
            }

        }

        // BOTÕES
        private void cadastrarCadClienteButton_Click(object sender, EventArgs e)
        {
            bool valido = true;

            // se alguma das textboxes obrigatórias não estiver preenchida
            foreach (TextBoxGrandeUserControl u in textboxesGrandes)
            {
                if (u.Text.Length == 0)
                {
                    // mostro um aviso
                    //u.Text = "Obrigatório >:|";
                    u.textBoxEscrever_Error();
                    // deixo inválido
                    valido = false;
                }
            }

            foreach (TextBoxMediaUserControl u in textboxesMedias)
            {
                if (u.Text.Length == 0)
                {
                    // mostro um aviso
                    //u.Text = "Obrigatório >:|";
                    u.textBoxEscrever_Error();
                    // deixo inválido
                    valido = false;
                }
            }

            foreach (TextBoxPequenaUserControl u in textboxesPequenas)
            {
                if (u.Text.Length == 0)
                {
                    // mostro um aviso
                    //u.Text = "Obrigatório >:|";
                    u.textBoxEscrever_Error();
                    // deixo inválido
                    valido = false;
                }
            }

            foreach (TextBoxMuitoPequenaUserControl u in textboxesMuitoPequenas)
            {
                if (u.Text.Length == 0)
                {
                    // mostro um aviso
                    //u.Text = "Obrigatório >:|";
                    u.textBoxEscrever_Error();
                    // deixo inválido
                    valido = false;
                }
            }

            if (valido)
            {
                // cadastro o cliente 
                clsCliente cliente = new clsCliente();
                cliente.Salvar();
            }
        }

        private void alterarCadClienteButton_Click(object sender, EventArgs e)
        {

        }

        private void excluirCadClienteButton_Click(object sender, EventArgs e)
        {

        }

        private void enderecoDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (enderecoDataGridView.SelectedRows.Count > 0)
            {
                tipoEndCadClienteTextBox.Text = enderecoDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                logradouroCadClienteTextBox.Text = enderecoDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                numEndCadClienteTextBox.Text = enderecoDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                cepEndCadClienteTextBox.Text = enderecoDataGridView.SelectedRows[0].Cells[5].Value.ToString();
                if (enderecoDataGridView.SelectedRows[0].Cells[6].Value != null)
                {
                    complEndCadClienteTextBox.Text = enderecoDataGridView.SelectedRows[0].Cells[6].Value.ToString();
                }
                cidadeEndCadClienteTextBox.Text = enderecoDataGridView.SelectedRows[0].Cells[7].Value.ToString();
                ufEndCadClienteTextBox.Text = enderecoDataGridView.SelectedRows[0].Cells[8].Value.ToString();
                paisEndCadClienteTextBox.Text = enderecoDataGridView.SelectedRows[0].Cells[9].Value.ToString();
            }
        }

        private void VisualizarClientes_Shown(object sender, EventArgs e)
        {
            // já que o usuário ainda não clicou em nada
            // não deixo controles ativos no primeiro momento
            this.ActiveControl = null;
            // deixo o data grid view deselecionado
            clienteDataGridView.Rows[0].Selected = false;
        }

        private void VisualizarClientes_Click(object sender, EventArgs e)
        {
            // já que o usuário ainda não clicou em nada
            // não deixo controles ativos no primeiro momento
            this.ActiveControl = null;
            nomeCadClienteTextBox.Text = "";
            cpfCadClienteTextBox.Text = "";
            dtNascCadClienteTextBox.Text = "";
            emailCadClienteTextBox.Text = "";
            // deixo o data grid view deselecionado
            clienteDataGridView.Rows[0].Selected = false;
        }
    }
}
