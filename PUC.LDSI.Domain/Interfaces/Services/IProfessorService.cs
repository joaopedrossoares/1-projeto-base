using System.Threading.Tasks;

namespace PUC.LDSI.Domain.Services
{
    public interface IProfessorService
    {
        
        Task<int>IncluirProfessorAsync(string nome);

    }
}
