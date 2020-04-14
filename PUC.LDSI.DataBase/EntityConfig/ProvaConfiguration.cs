using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUC.LDSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.DataBase.EntityConfig
{
    class ProvaConfiguration : IEntityTypeConfiguration<Prova>
    {
        public void Configure(EntityTypeBuilder<Prova> builder)
        {  
            builder.Property(x => x.DataPova).IsRequired();

            builder.Property(x => x.DataPova).HasColumnType("date");

            builder.HasOne(x => x.Avaliacao).WithMany(x => x.Provas).HasForeignKey(x => x.AvaliacaoId);

            builder.HasOne(x => x.Aluno).WithMany(x => x.Provas).HasForeignKey(x => x.AlunoId);

            new EntityConfiguration();
        }
    }
}
