using SC.API.Domain;
using System.Collections.Generic;

namespace Api.Data.Interfaces
{
    public interface IAlunoRepository
    {
        List<Aluno> Get();
        Aluno GetById(int id);
        void Add(Aluno aluno);
        void AddAll(List<Aluno> alunos);
        void Atualizar(Aluno aluno);
        void Delete(int id);
    }
}
