using Microsoft.EntityFrameworkCore;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Interfaces.Repository;
using System.Linq;
using System.Threading.Tasks;

namespace PUC.LDSI.DataBase.Repository
{
    public class OpcaoAvaliacaoRepository : Repository<OpcaoAvaliacao>, IOpcaoAvaliacaoRepository
    {
        private readonly AppDbContext _context;

        public OpcaoAvaliacaoRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<OpcaoAvaliacao> ObterAsync(int id)
        {
            var opcao_avaliacao = await _context.OpcaoAvaliacao
                .Include(x => x.OpcoesProvas)
                .Where(x => x.Id == id).FirstOrDefaultAsync();

            return opcao_avaliacao;
        }

        public async Task<OpcaoAvaliacao> ObterAsync()
        {
            var opcao_avaliacao = await _context.OpcaoAvaliacao
                .Include(x => x.OpcoesProvas)
                .FirstOrDefaultAsync();

            return opcao_avaliacao;
        }
    }
}
