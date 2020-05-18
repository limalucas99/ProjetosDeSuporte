using App.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace App.Repository
{
    public class AlunoDAO
    {


        private string stringConexao = ConfigurationManager.ConnectionStrings["ConexaoDev"].ConnectionString;
        private IDbConnection conexao;

        public AlunoDAO()
        {
            //string stringConexao = ConfigurationManager.AppSettings["ConnectionString"];

            conexao = new SqlConnection(stringConexao);
            
            conexao.Open();
        }

        public List<AlunoDTO> ListarAlunosDB(int? id)
        {

            try
            {
                var listaAlunos = new List<AlunoDTO>();

                IDbCommand comando = conexao.CreateCommand();

                if (id == null)
                    comando.CommandText = "select * from Alunos";
                else
                    comando.CommandText = $"select * from Alunos where id = {id}";

                IDataReader resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    var al = new AlunoDTO
                    {
                        id = Convert.ToInt32(resultado["id"]),
                        nome = Convert.ToString(resultado["nome"]),
                        sobrenome = Convert.ToString(resultado["sobrenome"]),
                        telefone = Convert.ToString(resultado["telefone"]),
                        ra = Convert.ToInt32(resultado["ra"]),
                    };
                    listaAlunos.Add(al);
                }



                return listaAlunos;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Close();
            }


           

        }

        public void InserirAlunoDB(AlunoDTO aluno)
        {
            try
            {
                IDbCommand insert = conexao.CreateCommand();
                insert.CommandText = "insert into Alunos (nome,sobrenome, telefone, ra) values (@nome,@sobrenome,@telefone,@ra)";

                IDbDataParameter paramNome = new SqlParameter("nome", aluno.nome);
                insert.Parameters.Add(paramNome);

                IDbDataParameter paramSobrenome = new SqlParameter("Sobrenome", aluno.sobrenome);
                insert.Parameters.Add(paramSobrenome);

                IDbDataParameter paramTelefone = new SqlParameter("telefone", aluno.telefone);
                insert.Parameters.Add(paramTelefone);

                IDbDataParameter paramRa = new SqlParameter("ra", aluno.ra);
                insert.Parameters.Add(paramRa);

                insert.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Close();
            }



        }

        public void AtualizarAlunoDB(AlunoDTO aluno)
        {

            try
            {
                IDbCommand update = conexao.CreateCommand();
                update.CommandText = "update Alunos set nome = @nome, sobrenome = @sobrenome, telefone = @telefone, ra = @ra where id = @id";

                IDbDataParameter paramNome = new SqlParameter("nome", aluno.nome);
                update.Parameters.Add(paramNome);

                IDbDataParameter paramSobrenome = new SqlParameter("Sobrenome", aluno.sobrenome);
                update.Parameters.Add(paramSobrenome);

                IDbDataParameter paramTelefone = new SqlParameter("telefone", aluno.telefone);
                update.Parameters.Add(paramTelefone);

                IDbDataParameter paramRa = new SqlParameter("ra", aluno.ra);
                update.Parameters.Add(paramRa);


                IDbDataParameter paramId = new SqlParameter("id", aluno.id);
                update.Parameters.Add(paramId);

                update.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
           
        }

        public void DeletarAlunoDB(int id)
        {
            try
            {
                IDbCommand delete = conexao.CreateCommand();
                delete.CommandText = "delete from Alunos where id = @id";

                IDbDataParameter paramId = new SqlParameter("id", id);
                delete.Parameters.Add(paramId);

                delete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
           
        }

    }
}