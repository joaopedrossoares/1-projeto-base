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
            builder.Property(x => x.Avaliacao).IsRequired();
            builder.Property(x => x.Avaliacao).HasColumnType("varchar(100)");

            new EntityConfiguration();
        }
    }
}
