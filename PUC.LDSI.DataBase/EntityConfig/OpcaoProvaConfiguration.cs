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
            builder.Property(x => x.OpcaoAvaliacao).IsRequired();
            builder.Property(x => x.QuestaoProva).HasColumnType("varchar(100)");
            builder.HasOne(x => x.QuestaoProva).WithMany(x => x.OpçoesProvas).HasForeignKey(x => x.QuestaoProvaId);
            new EntityConfiguration();
        }
    }
}
