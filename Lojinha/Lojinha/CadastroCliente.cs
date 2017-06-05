using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BancoModel;

namespace Lojinha
{
    public partial class VisualizarClientes : Form
    {
        // crio um vetor de textboxes 
        private textBoxUserControl[] textboxes;

        public VisualizarClientes()
        {
<<<<<<< HEAD
<<<<<<< HEAD
            textBoxUserControl nomeCadClienteTextBox = new textBoxUserControl();
            textBoxUserControl CpfCadClienteTextBox = new textBoxUserControl();
            textBoxUserControl dtNasCadClienteTextBox = new textBoxUserControl();
            textBoxUserControl emailCadClienteTextBox = new textBoxUserControl();
            textBoxUserControl senhaCadClienteTxtBox = new textBoxUserControl();
            textBoxUserControl celularCadClienteTxtBox = new textBoxUserControl();
            textBoxUserControl telResCadClienteTxtBox = new textBoxUserControl();
            textBoxUserControl telComCadClienteTxtBox = new textBoxUserControl();
            textBoxUserControl tipoEndCadClienteTxtBox = new textBoxUserControl();
            textBoxUserControl logadouroCadClienteTxtBox = new textBoxUserControl();
            textBoxUserControl nrResEndCadClienteTxtBox = new textBoxUserControl();
            textBoxUserControl cepCadClienteTxtBox = new textBoxUserControl();
            textBoxUserControl compleCadClienteTxtBox = new textBoxUserControl();
            textBoxUserControl cidadeClienteTxtBox = new textBoxUserControl();
            textBoxUserControl ufClienteTxtBox = new textBoxUserControl();
            textBoxUserControl paisCadClienteTxtBox = new textBoxUserControl();
=======
            textBoxUserControl nomeCadTxtBox = new textBoxUserControl();
            textBoxUserControl cpfCadTextBox = new textBoxUserControl();
            textBoxUserControl emailCadTextBox = new textBoxUserControl();
>>>>>>> 07843b5739acb018fdb3ac6d0d20a5f3758175a7
=======
            textBoxUserControl nomeCadTxtBox = new textBoxUserControl();
            textBoxUserControl cpfCadTextBox = new textBoxUserControl();
            textBoxUserControl emailCadTextBox = new textBoxUserControl();
>>>>>>> 07843b5739acb018fdb3ac6d0d20a5f3758175a7

            InitializeComponent();
            // listagem dos clientes cadastrados
            List<clsCliente> clientes = clsCliente.SelecionarClientes();
            // mostro a listagem na grid view
            ClientedataGridView.DataSource = clientes;
            //Escondendo os campos indesejados do gridview, deixando só o nome do cliente
            ClientedataGridView.Columns[0].Visible = false;
            ClientedataGridView.Columns[2].Visible = false;
            ClientedataGridView.Columns[3].Visible = false;
            ClientedataGridView.Columns[4].Visible = false;
            ClientedataGridView.Columns[5].Visible = false;
            ClientedataGridView.Columns[6].Visible = false;
            ClientedataGridView.Columns[7].Visible = false;
            ClientedataGridView.Columns[8].Visible = false;
            ClientedataGridView.Columns[9].Visible = false;

<<<<<<< HEAD
<<<<<<< HEAD
            // inicializo o vetor de textbox com as textboxes obrigatórias
            textboxes = new textBoxUserControl[]
            {
                nomeCadClienteTextBox,
                CpfCadClienteTextBox,
                dtNasCadClienteTextBox,
                emailCadClienteTextBox,
                senhaCadClienteTxtBox,
                celularCadClienteTxtBox,
                telResCadClienteTxtBox,
                telComCadClienteTxtBox,
                tipoEndCadClienteTxtBox,
                logadouroCadClienteTxtBox,
                nrResEndCadClienteTxtBox,
                cepCadClienteTxtBox,
                compleCadClienteTxtBox,
                cidadeClienteTxtBox,
                ufClienteTxtBox,
                paisCadClienteTxtBox
=======
            // inicializo o vetor de textbox
            // com as textboxes obrigatórias
            textboxes = new textBoxUserControl[]
            {
=======
            // inicializo o vetor de textbox
            // com as textboxes obrigatórias
            textboxes = new textBoxUserControl[]
            {
>>>>>>> 07843b5739acb018fdb3ac6d0d20a5f3758175a7
                nomeCadTxtBox,
                cpfCadTextBox,
                emailCadTextBox
               ///nomeCadClienteTextBox,
                //CpfCadClienteTextBox,
                //emailCadClienteTextBox
                //senhaCadClienteTxtBox,
                //celularCadClienteTxtBox,
                //logadouroCadClienteTxtBox,
                //nrResEndCadClienteTxtBox,
                //cepCadClienteTxtBox,
                //cidadeClienteTxtBox,
                //ufClienteTxtBox
<<<<<<< HEAD
>>>>>>> 07843b5739acb018fdb3ac6d0d20a5f3758175a7
=======
>>>>>>> 07843b5739acb018fdb3ac6d0d20a5f3758175a7
            };
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cadastrarCadClienteButton_Click(object sender, EventArgs e)
        {
            bool valido = true;

            // se alguma das textboxes obrigatórias não estiver preenchida
            foreach (textBoxUserControl t in textboxes)
            {
                if (t.Text.Length == 0)
                {
                    // mostro um aviso
                    t.Texto = "Obrigatório >:|";
                    t.textBoxEscrever_Error();
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

        private void ClientedataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ClientedataGridView.SelectedRows.Count > 0)
            {
                //colocando o valor nos txtBox
                nomeCadClienteTextBox.Text = ClientedataGridView.SelectedRows[0].Cells[1].Value.ToString();
                CpfCadClienteTextBox.Text = ClientedataGridView.SelectedRows[0].Cells[4].Value.ToString();
                if (ClientedataGridView.SelectedRows[0].Cells[5].Value != null)
                {
                    dtNasCadClienteTextBox.Text = ClientedataGridView.SelectedRows[0].Cells[8].Value.ToString();
                }
                emailCadClienteTextBox.Text = ClientedataGridView.SelectedRows[0].Cells[2].Value.ToString();
                senhaCadClienteTxtBox.Text = ClientedataGridView.SelectedRows[0].Cells[3].Value.ToString();
                if(ClientedataGridView.SelectedRows[0].Cells[5].Value != null)
                {
                    celularCadClienteTxtBox.Text = ClientedataGridView.SelectedRows[0].Cells[5].Value.ToString();
                }
                if (ClientedataGridView.SelectedRows[0].Cells[7].Value != null)
                {
                    telResCadClienteTxtBox.Text = ClientedataGridView.SelectedRows[0].Cells[7].Value.ToString();
                }
                if (ClientedataGridView.SelectedRows[0].Cells[6].Value != null)
                {
                    telComCadClienteTxtBox.Text = ClientedataGridView.SelectedRows[0].Cells[6].Value.ToString();
                }
                //adicionando os endereços no gridview dos endereço
                textBox1.Text = ClientedataGridView.SelectedRows[0].Cells[0].Value.ToString();
                List<clsEndereco> enderecos = clsEndereco.SelecionarEnderecos((int)Convert.ChangeType(textBox1.Text, typeof(int)));
                EnderecodataGridView.DataSource = enderecos;
            }
        }
    }
}
