using PUC.LDSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PUC.LDSI.Domain.Interfaces.Repository
{
    public interface IPublicacaoRepository : IRepository<Publicacao>
    {
        Task<List<Publicacao>> ListarPublicacoesDoAlunoAsync(Task<Aluno> aluno);
        Task<List<Publicacao>> ListarAvaliacoesDoProfessorAsync(int professorId);        
    }
}
      