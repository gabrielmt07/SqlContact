using Api.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SC.API.Domain;

namespace SC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoRepository _repository;

        public AlunoController(IAlunoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var alunos = _repository.Get();

            return Ok(alunos);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var aluno = _repository.GetById(id);
            return Ok(aluno);
        }

        [HttpPost]
        public ActionResult Post(Aluno aluno)
        {
            _repository.Add(aluno);
            return StatusCode(201);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Aluno aluno)
        {
            aluno.IdAluno = id;
            _repository.Atualizar(aluno);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _repository.Delete(id);
            return StatusCode(200);
        }
    }
}
