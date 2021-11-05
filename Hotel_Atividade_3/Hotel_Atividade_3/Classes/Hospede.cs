using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Hotel_Atividade_3.Classes
{
    public class Hospede
    {
        readonly Conexao conexao = new Conexao();
        SqlCommand query = new SqlCommand();
        Random randNum = new Random();

        public void Cadastrar(string cpf, string nome, string checkIn, string checkOut) {
            query.CommandText = "INSERT INTO tbHospedes (cpf, nome, dataCheckIn, dataCheckOut, numeroquarto) VALUES (@cpf, @nome, @dataCheckIn, @dataCheckOut, @quarto);"; 
            
            query.Parameters.AddWithValue("@cpf", cpf);
            query.Parameters.AddWithValue("@nome", nome);
            query.Parameters.AddWithValue("@dataCheckIn", checkIn);
            query.Parameters.AddWithValue("@dataCheckOut", checkOut);
            query.Parameters.AddWithValue("@quarto", randNum.Next(80));

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

        public DataTable ListarHospedes(int status) {
            if (status == 0)
            {
                query.CommandText = "SELECT * FROM tbHospedes ORDER BY id_hospede DESC;";
            }

            if(status == 1)
            {
                query.CommandText = "SELECT * FROM tbHospedes WHERE dataCheckIn >= @dataCheckIn AND dataCheckOut > @dataCheckOut;";

                query.Parameters.AddWithValue("@dataCheckIn", DateTime.Now.ToString("yyyy'-'MM'-'dd"));
                query.Parameters.AddWithValue("@dataCheckOut", DateTime.Now.ToString("yyyy'-'MM'-'dd"));
            }

            if (status == 2)
            {
                query.CommandText = "SELECT * FROM tbHospedes WHERE dataCheckIn >= @dataCheckIn AND dataCheckOut < @dataCheckOut;";

                query.Parameters.AddWithValue("@dataCheckIn", DateTime.Now.ToString("yyyy'-'MM'-'01"));
                query.Parameters.AddWithValue("@dataCheckOut", DateTime.Now.ToString("yyyy'-'MM'-'dd"));
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
