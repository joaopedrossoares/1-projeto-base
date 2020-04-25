using System;
using System.Collections.Generic;
using System.Text;
using PUC.LDSI.Domain.Interfaces.Repository;
using PUC.LDSI.Domain.Entities;

namespace PUC.LDSI.DataBase.Repository
{
    public class ProfessorRepository : Repository<Professor>, IProfessorRepository
    {
        private readonly AppDbContext _conxte;

        public ProfessorRepository(AppDbContext context) : base(context)
        {
            _conxte = context;
        }
    }
}
