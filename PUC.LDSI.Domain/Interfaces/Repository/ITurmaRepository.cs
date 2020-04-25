using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PUC.LDSI.Domain.Entities;

namespace PUC.LDSI.Domain.Interfaces.Repository
{
    public interface ITurmaRepository : IRepository<Turma>
    {
        Task<Turma> ObterAsync(int id);

    }
}
