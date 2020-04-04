using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUC.LDSI.Domain.Entities;

namespace PUC.LDSI.DataBase.EntityConfig
{
    public class OpcaoProvaConfiguration : IEntityTypeConfiguration<OpcaoProva>
    {
        public void Configure(EntityTypeBuilder<OpcaoProva> builder)
        {
            builder.Property(x => x.Resposta).HasColumnType("bit").IsRequired();

            builder.HasOne(x => x.OpcaoAvaliacao).WithMany(x => x.OpcoesProva).HasForeignKey(x => x.OpcaoAvaliacaoId).IsRequired();
            builder.HasOne(x => x.QuestaoProva).WithMany(x => x.OpçoesProvas).HasForeignKey(x => x.QuestaoProvaId).IsRequired();

            new EntityConfiguration();
        }
    }
}
