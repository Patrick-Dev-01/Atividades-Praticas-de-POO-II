using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hotel_Atividade_3
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Cadastro_Hospedes_Click(object sender, EventArgs e)
        {
            CadastroHospedes cadastroHospedes = new CadastroHospedes();
            cadastroHospedes.Show();
        }

        private void Cadastro_Funcionario_Click(object sender, EventArgs e)
        {
            CadastroFuncionarios cadastroFuncionarios = new CadastroFuncionarios();
            cadastroFuncionarios.Show();
        }

        private void Consulta_Funcionarios_Click(object sender, EventArgs e)
        {
            Funcionarios funcionarios = new Funcionarios();
            funcionarios.Show();
        }

        private void Consulta_Hospedes_Click(object sender, EventArgs e)
        {
            Hospedes hospedes = new Hospedes();
            hospedes.Show();
        }
    }
}
