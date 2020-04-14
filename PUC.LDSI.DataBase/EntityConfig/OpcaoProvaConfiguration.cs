using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUC.LDSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.DataBase.EntityConfig
{
    class OpcaoProvaConfiguration : IEntityTypeConfiguration<OpcaoProva>
    {
        public void Configure(EntityTypeBuilder<OpcaoProva> builder)
        {
            builder.HasOne(x => x.QuestaoProva).WithMany(x => x.OpcoesProvas).HasForeignKey(x => x.QuestaoProvaId);

            builder.HasOne(x => x.OpcaoAvaliacao).WithMany(x => x.OpcoesProvas).HasForeignKey(x => x.OpcaoAvaliacaoId);

            new EntityConfiguration();
        }
    }
}
