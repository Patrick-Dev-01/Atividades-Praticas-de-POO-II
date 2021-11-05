using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Grafico
{
    public class Produto
    {
        readonly Conexao conexao = new Conexao();
        SqlCommand query = new SqlCommand();

        public void CadastrarProduto(string nome, int quantidade, float preco) {
            query.CommandText = "INSERT INTO tbProdutos (nomeProduto, quantidade, preco) VALUES (@nomeProduto, @quantidade, @preco);";

            query.Parameters.AddWithValue("@nomeProduto", nome);
            query.Parameters.AddWithValue("@quantidade", quantidade);
            query.Parameters.AddWithValue("@preco", preco);

            try
            {
                query.Connection = conexao.Conectar();
                query.ExecuteNonQuery();

                conexao.Desconectar();
            }

            catch (SqlException)
            {
                throw;
            }
        }

        public DataTable ListarProdutos()
        {
     
            query.CommandText = "SELECT * FROM tbProdutos";

            try
            {
                query.Connection = conexao.Conectar();
                query.ExecuteNonQuery();
                // Ler os resultados da query
                SqlDataAdapter data = new SqlDataAdapter(query);
                DataTable dataLista = new DataTable();

                data.Fill(dataLista);

                conexao.Desconectar();

                return dataLista;
            }

            catch (SqlException)
            {
                throw;
            }
        }
    }
}
