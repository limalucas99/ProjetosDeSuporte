using App.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApp.Models;

namespace WebApp.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/Aluno")]
    public class AlunoController : ApiController
    {

        AlunoModel aluno = new AlunoModel();
        List<AlunoModel> alunos = new List<AlunoModel>();

        // GET: api/Aluno

        [HttpGet]
        [Route("Recuperar")]
        [Authorize(Roles = Funcao.Professor)]
        public IHttpActionResult Recuperar()
        {
            try
            {
                return Ok(aluno.ListarAluno());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }

        // GET: api/Aluno/5
        [HttpGet]
        [Route("Recuperar/{id}")]
        public AlunoDTO Get(int id)
        {
            return aluno.ListarAluno(id).FirstOrDefault();
        } 
        
        [HttpGet]
        [Route(@"RecuperarPorDataNome/{data:regex([0-9]{4}\-[0-9]{2})}/{nome:minlength(5)}")]
        public IHttpActionResult Recuperar(string data, string nome)
        {

            AlunoDTO alu = new AlunoDTO();

            try
            {
                IEnumerable<AlunoDTO> alunos = aluno.ListarAluno().Where(x => x.data == data || x.nome == nome);
                if (!alunos.Any())
                {
                    return NotFound();
                }
                return Ok(alunos);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        
        }

        // POST: api/Aluno
        [HttpPost]
        public IHttpActionResult Post(AlunoDTO _aluno)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                aluno.Inserir(_aluno);

                return Ok(aluno.ListarAluno());
            }

            catch (Exception ex)
            {

                return InternalServerError(ex);
            }
        }

        // PUT: api/Aluno/5
        [HttpPut]
        public IHttpActionResult Put(int id, AlunoDTO _aluno)
        {
            AlunoDTO alu = new AlunoDTO();

            try
            {
                _aluno.id = id;
                aluno.Atualizar(_aluno);
                //VAI RETORNAR O RETORNO DO MÉTODO Atualizar();

                return Ok(aluno.ListarAluno(id).FirstOrDefault());
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }
          
        }

        // DELETE: api/Aluno/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                aluno.Deletar(id);
                return Ok("Deletado com sucesso");
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }
            
        }
    }
}
