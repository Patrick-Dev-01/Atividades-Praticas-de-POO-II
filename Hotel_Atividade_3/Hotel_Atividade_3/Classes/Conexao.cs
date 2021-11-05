using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Hotel_Atividade_3
{
    class Conexao
    {
        readonly SqlConnection connection = new SqlConnection();

        public Conexao()
        {
            connection.ConnectionString = @"Data Source=DESKTOP-BS2L6RM\MSSQLSERVER01; integrated security=SSPI;initial catalog=hotel";
        }

        public SqlConnection Conectar()
        {
            connection.Open();

            return connection;
        }

        public void Desconectar()
        {
            connection.Close();
        }
    }
}
