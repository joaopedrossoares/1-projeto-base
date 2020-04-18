using PUC.LDSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PUC.LDSI.Domain.Interfaces.Services
{
    public interface IProfessoeService
    {
        Task<int> AdicionarProfessorAsync(string descricao);
        Task<int> AlterarProfessorAsync(int id, string descricao);
        List<Professor> Listaprofessor();
        Task<Professor> ObterAsync(int id);
        Task ExcluirAsync(int id);

    }
}
