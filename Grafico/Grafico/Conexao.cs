using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Grafico
{
    public class Conexao
    {
        SqlConnection connection = new SqlConnection();

        public SqlConnection Conectar() {
            connection.ConnectionString = @"Data Source=DESKTOP-BS2L6RM\MSSQLSERVER01; integrated security=SSPI;initial catalog=Produtos";

            connection.Open();

            return connection;
        }

        public void Desconectar() {
            connection.Close();
        }
    }
}
