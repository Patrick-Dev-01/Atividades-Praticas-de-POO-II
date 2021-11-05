using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace ExemploFuncao
{
    public class Operacao
    {
        string strConexao = "";
        string query = "";
        string retornoFuncao = "";
        SqlConnection conexao = null;
        SqlCommand comando = null;

        public string RealizarOperacao(string numero1, string numero2, string operacao) {
            strConexao = @"Data Source=DESKTOP-BS2L6RM\MSSQLSERVER01; integrated security=SSPI;initial catalog=MATEMATICA";

            query = "SELECT DBO.UFN_"+ operacao +"(@NUMERO1, @NUMERO2)";

            conexao = new SqlConnection(strConexao);
            comando = new SqlCommand(query, conexao);

            SqlParameter Numero1 = new SqlParameter("@NUMERO1", SqlDbType.Int);
            Numero1.Value = int.Parse(numero1);
            comando.Parameters.Add(Numero1);

            SqlParameter Numero2 = new SqlParameter("@NUMERO2", SqlDbType.Int);
            Numero2.Value = int.Parse(numero2);
            comando.Parameters.Add(Numero2);

            conexao.Open();

            retornoFuncao = comando.ExecuteScalar().ToString();

            return retornoFuncao;
        }
    }
}
