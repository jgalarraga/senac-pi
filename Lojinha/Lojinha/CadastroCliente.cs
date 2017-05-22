﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BancoModel;

namespace Lojinha
{
    public partial class VisualizarClientes : Form
    {
        // crio um vetor de textboxes 
        private TextBox[] textboxes;

        public VisualizarClientes()
        {
            InitializeComponent();
            // listagem dos clientes cadastrados
            List<clsCliente> clientes = clsCliente.SelecionarClientes();
            // mostro a listagem na grid view
            dataGridView1.DataSource = clientes;

            // inicializo o vetor de textbox
            // com as textboxes obrigatórias
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
            foreach (TextBox t in textboxes)
            {
                if (t.Text.Length == 0)
                {
                    // mostro um aviso
                    t.Text = "Obrigatório >:|";
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
