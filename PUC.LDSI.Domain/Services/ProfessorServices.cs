using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Exception;
using PUC.LDSI.Domain.Interfaces.Repository;
using PUC.LDSI.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PUC.LDSI.Domain.Services
{
    class ProfessorServices : IProfessorService
    {
        private readonly IProfessorRepository _professorRepository;
        public async Task<int> IncluirProfessorAsync(string nome)
        {
            Professor professor = new Professor() {Nome = nome };
            var erros = professor.Validate();
            if (erros.Length == 0)
            {
                await _professorRepository.AdicionarAsync(professor);
                _professorRepository.SaveChanges();
                return professor.Id;

            }
            else throw new DomainException(erros);
        }
    }
}
