using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUC.LDSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.DataBase.EntityConfig
{
    class QuestaoAvaliacaoConfiguration : IEntityTypeConfiguration<Questao>
    {
        public void Configure(EntityTypeBuilder<Questao> builder)
        {
            builder.Property(x => x.Tipo).IsRequired();
            builder.Property(x => x.Tipo).HasColumnType("tinyint)");

            builder.Property(x => x.Enunciado).IsRequired();
            builder.Property(x => x.Enunciado).HasColumnType("varchar(max)");

            builder.HasOne(x => x.Avaliacao).WithMany(x => x.Questoes).HasForeignKey(x => x.AvaliacaoId);

            new EntityConfiguration();
        }
    }
}
