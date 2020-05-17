using System;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Interfaces.Repository;

namespace PUC.LDSI.DataBase.Repository
{
    public class AlunoRepository : Repository<Aluno>, IAlunoRepository
    {
        public AlunoRepository(AppDbContext context) : base(context) { }

        public static object ObterAsync(object integrationId)
        {
            throw new NotImplementedException();
        }
    }
}