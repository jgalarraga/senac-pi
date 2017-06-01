using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BancoModel;

namespace Lojinha
{
    public partial class VisualizarClientes : Form
    {
        // crio um vetor de textboxes 
<<<<<<< HEAD
        private textBoxUserControl[] textboxes;
=======
        private TextBox[] textboxes;
>>>>>>> 3b95b64970949f7a702db7382e92321347b5e16e

        public VisualizarClientes()
        {
            InitializeComponent();
            // listagem dos clientes cadastrados
            List<clsCliente> clientes = clsCliente.SelecionarClientes();
            // mostro a listagem na grid view
            dataGridView1.DataSource = clientes;

            // inicializo o vetor de textbox
            // com as textboxes obrigatórias
<<<<<<< HEAD
            textboxes = new textBoxUserControl[]
            {
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
=======
            textboxes = new TextBox[]
            {
                nomeCadClienteTxtBox,
                CpfCadClienteTxtBox,
                emailCadClienteTxtBox,
                senhaCadClienteTxtBox,
                celularCadClienteTxtBox,
                logadouroCadClienteTxtBox,
                nrResEndCadClienteTxtBox,
                cepCadClienteTxtBox,
                cidadeClienteTxtBox,
                ufClienteTxtBox
>>>>>>> 3b95b64970949f7a702db7382e92321347b5e16e
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
<<<<<<< HEAD
            foreach (textBoxUserControl t in textboxes)
=======
            foreach (TextBox t in textboxes)
>>>>>>> 3b95b64970949f7a702db7382e92321347b5e16e
            {
                if (t.Text.Length == 0)
                {
                    // mostro um aviso
<<<<<<< HEAD
                    t.Texto = "Obrigatório >:|";
                    t.textBoxEscrever_Error();
=======
                    t.Text = "Obrigatório >:|";
>>>>>>> 3b95b64970949f7a702db7382e92321347b5e16e
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
    }
}
