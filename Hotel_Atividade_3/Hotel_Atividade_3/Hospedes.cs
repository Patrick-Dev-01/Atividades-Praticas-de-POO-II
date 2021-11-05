using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hotel_Atividade_3
{
    public partial class Hospedes : Form
    {
        public Hospedes()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Classes.Hospede funcionario = new Classes.Hospede();

            try
            {
                dataGridView1.DataSource = funcionario.ListarHospedes(comboBox1.SelectedIndex);
            }

            catch
            {
                MessageBox.Show("Não possivel buscar funcionarios", "Erro");
            }
        }
    }
}
