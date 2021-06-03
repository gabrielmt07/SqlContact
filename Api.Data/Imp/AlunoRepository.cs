using Api.Data.Interfaces;
using SC.API.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Api.Data.Imp
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly MainContext _db;

        public AlunoRepository(MainContext db)
        {
            _db = db;
        }

        public List<Aluno> Get()
        {
            return _db.Alunos.ToList();
        }

        public Aluno GetById(int id)
        {
            return _db.Alunos.Find(id);
        }

        public void Add(Aluno aluno)
        {
            _db.Add(aluno);
            _db.SaveChanges();
        }

        public void Atualizar(Aluno aluno)
        {
            _db.Update(aluno);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var aluno = GetById(id);
            _db.Remove(aluno);
            _db.SaveChanges();
        }
    }
}
