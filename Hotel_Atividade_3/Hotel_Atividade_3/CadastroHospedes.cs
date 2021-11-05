using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hotel_Atividade_3
{
    public partial class CadastroHospedes : Form
    {
        public CadastroHospedes()
        {
            InitializeComponent();
        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            Classes.Hospede hospede = new Classes.Hospede();
            
            try
            {
                hospede.Cadastrar(maskedTextBox1.Text, textBox1.Text, maskedTextBox2.Text, maskedTextBox3.Text);

                MessageBox.Show("Hospede Cadastrado com Sucesso", "Cadastro");
            }

            catch { 
                MessageBox.Show("Erro ao tentar cadastrar hospede", "Cadastro");
            }
        }
    }
}
