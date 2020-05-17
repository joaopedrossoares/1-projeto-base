using Microsoft.EntityFrameworkCore;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Interfaces.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PUC.LDSI.DataBase.Repository
{
    public class PublicacaoRepository : Repository<Publicacao>, IPublicacaoRepository
    {
        private readonly AppDbContext _context;

        public PublicacaoRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public virtual Task<List<Publicacao>> ListarPublicacoesDoProfessorAsync(int professorId)
        {
            var avaliacoes = _context.Publicacao
                .Include(x => x.Avaliacao)
                .ThenInclude(x => x.Professor)
                .Include(x => x.Turma)
                .Where(x => x.Avaliacao.ProfessorId == professorId).ToListAsync();

            return avaliacoes;
        }

        public async override Task<Publicacao> ObterAsync(int id)
        {
            var publicacao = await _context.Publicacao
                .Include(x => x.Avaliacao)
                .Include(x => x.Turma)
                .Where(x => x.Id == id).FirstOrDefaultAsync();

            return publicacao;
        }
        public async Task<Publicacao> ListarPublicacoesDoAlunoAsync(int IDAluno)
        {
            var avaliacoes = await _context.Publicacao
                 .Include(x => x.Avaliacao)
                 .ThenInclude(x => x.Professor)
                 .Include(x => x.Turma)
                 .Where(x => x.Avaliacao.ProfessorId == IDAluno).FirstOrDefaultAsync();

            return avaliacoes;

        }
    }
}