﻿using System;
using System.Collections.Generic;
using System.Text;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Interfaces.Repository;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PUC.LDSI.DataBase.Repository
{
    public class TurmaRepository : Repository<Turma>, ITurmaRepository
    {
        private readonly AppDbContext _context;

        public TurmaRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<Turma> ObterAsync(int id)
        {
            var turma = await _context.Turma.Include(x => x.Alunos).Where(x => x.Id == id).FirstOrDefaultAsync();

            return turma;
        }
    }
}
