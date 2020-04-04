using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUC.LDSI.Domain.Entities;

namespace PUC.LDSI.DataBase.EntityConfig
{
    public class QuestaoProvaConfiguration : IEntityTypeConfiguration<QuestaoProva>
    {
        public void Configure(EntityTypeBuilder<QuestaoProva> builder)
        {
            builder.Property(x => x.Nota).HasColumnType("decimal").IsRequired();

            builder.HasOne(x => x.Questao).WithMany(x => x.QuestaoProvas).HasForeignKey(x => x.QuestaoId).IsRequired();
            builder.HasOne(x => x.Prova).WithMany(x => x.QuestaoProvas).HasForeignKey(x => x.ProvaId).IsRequired();

            new EntityConfiguration();
        }
    }
}
