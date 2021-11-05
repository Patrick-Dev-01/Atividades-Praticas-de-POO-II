using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace TelaLogin
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BS2L6RM\MSSQLSERVER01; integrated security=SSPI;initial catalog=Cadastro");

            string strSQL = "INSERT INTO clientes (cpf, nome, email, celular, data_nascimento) VALUES " +
            "('" + textBox_cpf.Text + "', '" + textBox_nome.Text + "', '" + textBox_email.Text + "', '" + textBox_celular.Text + "', '" + maskedTextBox_nascimento.Text + "');";

            connection.Open();

            SqlCommand query = new SqlCommand(strSQL, connection);
            query.ExecuteNonQuery();

            MessageBox.Show("Usuário cadastrado com sucesso!", "Cadastro");

            connection.Close();
        }
    }
}
