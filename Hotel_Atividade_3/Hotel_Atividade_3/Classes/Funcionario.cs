using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Hotel_Atividade_3.Classes
{
    public class Funcionario
    {
        readonly Conexao conexao = new Conexao();
        SqlCommand query = new SqlCommand();

        public void Cadastrar(string cpf, string nome, string dt_nascimento, string dt_contratacao)
        {
            query.CommandText = "INSERT INTO tbFuncionario (cpf, nome, data_nascimento, data_contratacao, status) VALUES (@cpf, @nome, @data_nascimento, @data_contratacao, 'A');";

            query.Parameters.AddWithValue("@cpf", cpf);
            query.Parameters.AddWithValue("@nome", nome);
            query.Parameters.AddWithValue("@data_nascimento", dt_nascimento);
            query.Parameters.AddWithValue("@data_contratacao", dt_contratacao);

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

        public DataTable ListarFuncionarios(string cpf, string nome, string status) {
            if (cpf.Equals("") && nome.Equals("") && status.Equals(""))
            {
                query.CommandText = "SELECT * FROM tbFuncionario;";
            }

            else { 
                query.CommandText = "SELECT * FROM tbFuncionario WHERE cpf = @cpf OR nome = @nome OR status = @status;";
                
                query.Parameters.AddWithValue("@cpf", cpf);
                query.Parameters.AddWithValue("@nome", nome);
                query.Parameters.AddWithValue("@status", status);
            }

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
