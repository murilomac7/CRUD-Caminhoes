using CRUD_Caminhoes.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Caminhoes.Repository
{
    public class CaminhaoRepository : Conexao
    {
        public bool AddCaminhao(Caminhao caminhao)
        {
            try
            {                
                AbrirConexao();

                command = new SqlCommand("CriarCaminhao", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Nome", caminhao.Nome);
                command.Parameters.AddWithValue("@DtCriacao", caminhao.DtCriacao);
                command.Parameters.AddWithValue("@Descricao", caminhao.Descricao);

                int i = command.ExecuteNonQuery();

                if (i >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao Adicionar novo Caminhão: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        // Método: READ 
        public List<Caminhao> SelecionarCaminhao()
        {
            try
            {
                AbrirConexao();

                command = new SqlCommand("SelecionarCaminhao", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Aqui irá ler os registros obtidos através do SqlDataReader
                dataReader = command.ExecuteReader();

                // Criando uma lista vazia
                var lista = new List<Caminhao>();

                while (dataReader.Read())
                {
                    Caminhao caminhao = new Caminhao
                    {
                        Id = Convert.ToInt32(dataReader["Id"]),
                        Nome = Convert.ToString(dataReader["Nome"]),
                        DtCriacao = Convert.ToDateTime(dataReader["DtCriacao"]),
                        Descricao = Convert.ToString(dataReader["Descricao"]),
                    };

                    lista.Add(caminhao);
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao selecionar o Caminhão: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        // Método: Update
        public bool AtualizarCaminhao(Caminhao caminhao)
        {
            try
            {
                AbrirConexao();
                command = new SqlCommand("AtualizarCaminhao", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", caminhao.Id);
                command.Parameters.AddWithValue("@Nome", caminhao.Nome);
                command.Parameters.AddWithValue("@DtCriacao", caminhao.DtCriacao);
                command.Parameters.AddWithValue("@Descricao", caminhao.Descricao);

                int i = command.ExecuteNonQuery();

                if (i >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao Atualizar Caminhão: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        // Método: Delete
        public bool ExcluirCaminhao(Caminhao caminhao)
        {
            try
            {
                AbrirConexao();
                command = new SqlCommand("ExcluirCaminhao", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", caminhao.Id);

                int i = command.ExecuteNonQuery();

                if (i >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao excluir Caminhão: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }    
}
