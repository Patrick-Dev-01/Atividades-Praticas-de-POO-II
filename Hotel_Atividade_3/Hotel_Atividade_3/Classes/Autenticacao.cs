using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Hotel_Atividade_3.Classes
{
    public class Autenticacao
    {
        readonly Conexao conexao = new Conexao();
        SqlCommand query = new SqlCommand();
        SqlDataReader data;

        public bool resultado = false;
        public string mensagem;

        public bool Autenticar(String usuario, String senha) {
            query.CommandText = "SELECT login, senha FROM tbLogin WHERE login = @usuario AND senha = @senha";

            query.Parameters.AddWithValue("@usuario", usuario);
            query.Parameters.AddWithValue("@senha", senha);

            try
            {
                query.Connection = conexao.Conectar();
                data = query.ExecuteReader();

                if (data.HasRows) {
                    resultado = true;
                }

                conexao.Desconectar();
            }

            catch(SqlException) {
                throw;
            }

            return resultado;
        }
    }
}
