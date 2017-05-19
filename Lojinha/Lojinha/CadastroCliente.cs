using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoModel;

namespace Lojinha
{
    public partial class VisualizarClientes : Form
    {
        public VisualizarClientes()
        {
            InitializeComponent();
            // listagem dos clientes cadastrados
            List<clsCliente> clientes = clsCliente.SelecionarClientes();
            // mostro a listagem na grid view
            dataGridView1.DataSource = clientes;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void emailCadClienteTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tipoEndCadClienteLabel_Click(object sender, EventArgs e)
        {

        }

        private void tipoEndCadClienteTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void VisualizarClientes_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
