using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hotel_Atividade_3
{
    public partial class Funcionarios : Form
    {
        public Funcionarios()
        {
            InitializeComponent();
        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
            Classes.Funcionario funcionario = new Classes.Funcionario();

            try {
                dataGridView1.DataSource = funcionario.ListarFuncionarios("", "", "");
            }

            catch {
                MessageBox.Show("Não possivel buscar funcionarios", "Erro");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes.Funcionario funcionario = new Classes.Funcionario();

            try
            {
                dataGridView1.DataSource = funcionario.ListarFuncionarios(maskedTextBox1.Text, textBox1.Text, comboBox_status.Text.ToUpper().Substring(0, 1));
            }

            catch
            {
                MessageBox.Show("Não possivel buscar funcionarios", "Erro");
            }
        }
    }
}
