using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CRUD_Caminhoes.Repository
{
    public class Conexao
    {
        private const string ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=db_Caminhao;Trusted_Connection=True;MultipleActiveResultSets=true";
        protected SqlConnection connection;

        protected SqlCommand command;

        protected SqlDataReader dataReader;

        //Método para abrir a conexão com o SqlServer
        protected void AbrirConexao()
        {
            try
            {
                connection = new SqlConnection(ConnectionString);
                connection.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao abrir a conexão: " + e.Message);
            }
        }

        //Método para fechar a conexão:
        protected void FecharConexao()
        {
            try
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao fechar a conexão: " + e.Message);
            }
        }
    }
}
