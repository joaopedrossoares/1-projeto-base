using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUC.LDSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.DataBase.EntityConfig
{
    class QuestaoAvaliacaoConfiguration : IEntityTypeConfiguration<QuestaoProva>
    {
        public void Configure(EntityTypeBuilder<QuestaoProva> builder)
        {
            builder.Property(x => x.Questao).IsRequired();
            builder.Property(x => x.Questao).HasColumnType("varchar(100)");

            new EntityConfiguration();
        }
    }
}
