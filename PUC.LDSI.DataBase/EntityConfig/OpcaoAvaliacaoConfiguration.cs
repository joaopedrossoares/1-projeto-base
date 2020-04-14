using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUC.LDSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.DataBase.EntityConfig
{
    class OpcaoAvaliacaoConfiguration : IEntityTypeConfiguration<OpcaoAvaliacao>
    {
        public void Configure(EntityTypeBuilder<OpcaoAvaliacao> builder)
        {
            builder.Property(x => x.Descricao).IsRequired();

            builder.Property(x => x.Descricao).HasColumnType("varchar(200)");

            builder.HasOne(x => x.Questao).WithMany(x => x.OpcoesAvaliacoes).HasForeignKey(x => x.QuestaoId);

            new EntityConfiguration();
        }
    }
}
