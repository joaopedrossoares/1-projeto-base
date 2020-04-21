using Microsoft.EntityFrameworkCore;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Interfaces.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PUC.LDSI.DataBase.Repository
{
    public class QuestaoAvaliacaoRepository : Repository<Questao>, IQuestaoAvaliacaoRepository
    {
        private readonly AppDbContext _context;

        public QuestaoAvaliacaoRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<Questao> ObterAsync(int id)
        {
            var questao = await _context.Questao.Include(x => x.Avaliacao)
                .Include(x => x.OpcoesAvaliacoes)
                .Include(x => x.QuestoesProvas)
                .Where(x => x.Id == id).FirstOrDefaultAsync();

            return questao;
        }

        public virtual async Task<Questao> ObterAsync()
        {
            var questao = await _context.Questao
                .Include(x => x.Avaliacao)
                .ThenInclude(x => x.Questoes)
                .Include(x => x.OpcoesAvaliacoes)
                .Include(x => x.QuestoesProvas)
                .ThenInclude(x => x.OpcoesProvas)
                .FirstOrDefaultAsync();

            return questao;
        }
    }
}
