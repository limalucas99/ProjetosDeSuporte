using App.Domain;
using App.Repository;
using System;
using System.Collections.Generic;

namespace WebApp.Models
{
    public class AlunoModel
    {

        


        public List<AlunoDTO> ListarAluno(int? id = null)
        {
            try
            {
                var alunoBD = new AlunoDAO();
                return alunoBD.ListarAlunosDB(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao listar alunos: Erro => {ex.Message}");
            }



            /*
            var caminhoArquivo = HostingEnvironment.MapPath(@"~\App_Data\Base.json");
            var json = File.ReadAllText(caminhoArquivo);
            var listaAlunos = JsonConvert.DeserializeObject<List<Aluno>>(json);

            return listaAlunos;
            */
        }

       
        

     

        /*
        public bool ReescreverArquivo(List<AlunoModel> listaAlunos)
        {
            var caminhoArquivo = HostingEnvironment.MapPath(@"~\App_Data\Base.json");

            var json = JsonConvert.SerializeObject(listaAlunos, Formatting.Indented);

            File.WriteAllText(caminhoArquivo, json);


            return true;

        }
        */

        public void Inserir(AlunoDTO Aluno)
        {

            try
            {
                var alunoBD = new AlunoDAO();
                alunoBD.InserirAlunoDB(Aluno);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir aluno: Erro => {ex.Message}");
            }



            /*
            var listaAlunos = ListarAluno();

            var maxId = listaAlunos.Max(aluno => aluno.id);

            Aluno.id = maxId + 1;

            listaAlunos.Add(Aluno);

            ReescreverArquivo(listaAlunos);

            return Aluno;
            */

        }


        public void Atualizar(AlunoDTO Aluno)
        {

            try
            {
                var alunoBD = new AlunoDAO();
                alunoBD.AtualizarAlunoDB(Aluno);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Atualizar aluno: Erro => {ex.Message}");
            }

            /*
            var listaAlunos = ListarAluno();

            var itemIndex = listaAlunos.FindIndex(p => p.id == id);

            if(itemIndex >= 0)
            {
                Aluno.id = id;//Confirmar que o id do Aluno passado é igual ao id passado(NÃO ESTÁ MUITO CLARO)
                //PORQUE EU PASSARIA O ID DO ALUNO?????
                listaAlunos[itemIndex] = Aluno;
            }
            else
            {
                return null;
            }

            ReescreverArquivo(listaAlunos);
            return Aluno;
            */
        }

        public void Deletar(int id)
        {

            try
            {
                var alunoBD = new AlunoDAO();
                alunoBD.DeletarAlunoDB(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao deletar aluno: Erro => {ex.Message}");
            }




            //var listaAlunos = ListarAluno();

            //var itemIndex = listaAlunos.FindIndex(p => p.id == id);

            //if(itemIndex >= 0)
            //{
            //    listaAlunos.RemoveAt(itemIndex);
            //}
            //else
            //{
            //    return false;
            //}

            //ReescreverArquivo(listaAlunos);
            //return true;
        }

        /*
        public List<Aluno> listaAlunos()
        {
            
            Alunos aluno = new Alunos();
            aluno.id = 1;
            aluno.nome = "Marta";
            aluno.sobrenome = "Alves";
            aluno.telefone = "123456";
            aluno.ra = 00001;

            Alunos aluno2 = new Alunos();
            aluno2.id = 2;
            aluno2.nome = "Juca";
            aluno2.sobrenome = "Alves";
            aluno2.telefone = "654321";
            aluno2.ra = 00002;

            List<Alunos> listaAlunos = new List<Alunos>();

            listaAlunos.Add(aluno);
            listaAlunos.Add(aluno2);
            

            var caminhoArquivo = HostingEnvironment.MapPath(@"~\App_Data\Base.json");

            var json = File.ReadAllText(caminhoArquivo);

            var listaAlunos = JsonConvert.DeserializeObject<List<Aluno>>(json);

            return listaAlunos;
        }
    */
    }
}