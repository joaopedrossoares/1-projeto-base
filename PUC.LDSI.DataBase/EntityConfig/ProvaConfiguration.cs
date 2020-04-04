﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUC.LDSI.Domain.Entities;

namespace PUC.LDSI.DataBase.EntityConfig
{
    public class ProvaConfiguration : IEntityTypeConfiguration<Prova>
    {
        public void Configure(EntityTypeBuilder<Prova> builder)
        {
            builder.Property(x => x.DataProva).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.NotaObtida).HasColumnType("decimal").IsRequired();

            builder.HasOne(x => x.Aluno).WithMany(x => x.Provas).HasForeignKey(x => x.AlunoId).IsRequired();
            builder.HasOne(x => x.Avaliacao).WithMany(x => x.Provas).HasForeignKey(x => x.AvaliacaoId).IsRequired();

            new EntityConfiguration();
        }
    }
}
