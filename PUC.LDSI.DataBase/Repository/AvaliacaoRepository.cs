using Microsoft.EntityFrameworkCore;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Interfaces.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PUC.LDSI.DataBase.Repository
{
    public class AvaliacaoRepository : Repository<Avaliacao>, IAvaliacaoRepository
    {
        private readonly AppDbContext _context;

        public AvaliacaoRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<Avaliacao> ObterAsync(int id)
        {
            var avaliacao = await _context.Avaliacao
                .Include(x => x.Questoes)
                .ThenInclude(questoes => questoes.OpcoesAvaliacoes)
                .Include(x => x.Professor)
                .Where(x => x.Id == id).FirstOrDefaultAsync();

            return avaliacao;
        }

        public virtual Task<List<Avaliacao>> ListarAvaliacoesDoProfessorAsync(int professorId)
        {
            var avaliacoes = _context.Avaliacao
                .Include(x => x.Professor)
                .Where(x => x.ProfessorId == professorId).ToListAsync();

            return avaliacoes;
        }

    }
}
