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
            builder.Property(x => x.QuestoesProva).IsRequired();
            builder.Property(x => x.QuestoesProva).HasColumnType("varchar(100)");
            new EntityConfiguration();
        }
    }
}
