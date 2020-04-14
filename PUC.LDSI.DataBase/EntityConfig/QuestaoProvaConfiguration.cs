using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUC.LDSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.DataBase.EntityConfig
{
    class QuestaoProvaConfiguration : IEntityTypeConfiguration<QuestaoProva>
    {
        public void Configure(EntityTypeBuilder<QuestaoProva> builder)
        {
            builder.HasOne(x => x.Prova).WithMany(x => x.QuestoesProvas).HasForeignKey(x => x.ProvaId);

            builder.HasOne(x => x.Questao).WithMany(x => x.QuestoesProvas).HasForeignKey(x => x.QuestaoId);

            new EntityConfiguration();
        }
    }
}
