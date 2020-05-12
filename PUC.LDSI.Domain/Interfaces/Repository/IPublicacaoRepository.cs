using PUC.LDSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PUC.LDSI.Domain.Interfaces.Repository
{
    public interface IPublicacaoRepository : IRepository<Publicacao>
    {
        Task<List<Publicacao>> ListarPublicacoesDoProfessorAsync(int professorId);
        Task<Publicacao> ObterAsync(int id);
    }
}
