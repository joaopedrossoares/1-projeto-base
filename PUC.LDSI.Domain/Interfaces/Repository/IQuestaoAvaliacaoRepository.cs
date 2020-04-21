using PUC.LDSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PUC.LDSI.Domain.Interfaces.Repository
{
    public interface IQuestaoAvaliacaoRepository : IRepository<Questao>
    {
        Task<Questao> ObterAsync();
    }
}
