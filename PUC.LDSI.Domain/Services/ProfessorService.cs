using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Interfaces.Repository;
using PUC.LDSI.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PUC.LDSI.Domain.Exception;
using System.Linq;

namespace PUC.LDSI.Domain.Services
{
    public class ProfessorService : IProfessoeService
    {
        private readonly IProfessorRepository _professorRepository;

        public ProfessorService (IProfessorRepository professorRepository)
        {
            _professorRepository = professorRepository;
        }

        public async Task<int> AdicionarProfessorAsync(string descricao)
        {
            var professor = new Professor() { Nome = descricao };

            var erro = professor.Validate();

            if (erro.Length == 0)
            {
                await _professorRepository.AdicionarAsync(professor);

                _professorRepository.SaveChanges();

                return professor.Id;
            }
            else throw new DomainException(erro);
        }

        public async Task<int> AlterarProfessorAsync(int id, string descricao)
        {
            var professor = await _professorRepository.ObterAsync(id);

            professor.Nome = descricao;

            var erro = professor.Validate();

            if(erro.Length == 0)
            {
                _professorRepository.Modificar(professor);

                return _professorRepository.SaveChanges();
            }
            else throw new DomainException(erro);

        }

        public async Task ExcluirAsync(int id)
        {
            var professor = await _professorRepository.ObterAsync(id);

            _professorRepository.Excluir(id);

            _professorRepository.SaveChanges();
        }

        public List<Professor> Listaprofessor()
        {
            var lista = _professorRepository.ObterTodos().ToList();
            return lista;
        }

        public async Task<Professor> ObterAsync(int id)
        {
            var professor = await _professorRepository.ObterAsync(id);

            return professor;
        }
    }
}
