using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUC.LDSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.DataBase.EntityConfig
{
    class PublicacaoConfiguration : IEntityTypeConfiguration<Publicacao>
    {
        public void Configure(EntityTypeBuilder<Publicacao> builder)
        {
            builder.Property(x => x.DataInicio).IsRequired();
            builder.Property(x => x.DataInicio).HasColumnType("date");

            builder.Property(x => x.DataFim).IsRequired();
            builder.Property(x => x.DataFim).HasColumnType("date");

            builder.Property(x => x.ValorProva).IsRequired();
            builder.Property(x => x.ValorProva).HasColumnType("float");

            builder.HasOne(x => x.Avaliacao).WithMany(x => x.Publicacoes).HasForeignKey(x => x.AvaliacaoId);
            builder.HasOne(x => x.Turma).WithMany(x => x.Publicacoes).HasForeignKey(x => x.TurmaId);

            new EntityConfiguration();
        }
    }
}
