using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUC.LDSI.Domain.Entities;

namespace PUC.LDSI.DataBase.EntityConfig
{
    public class OpcaoAvaliacaoConfiguration : IEntityTypeConfiguration<OpcaoAvaliacao>
    {
        public void Configure(EntityTypeBuilder<OpcaoAvaliacao> builder)
        {
            
            builder.Property(x => x.Descricao).HasColumnType("text").IsRequired();
            builder.Property(x => x.Verdadeira).HasColumnType("bit").IsRequired();

            builder.HasOne(x => x.Questao).WithMany(x => x.OpcaoAvaliacoes).HasForeignKey(x => x.QuestaoId).IsRequired();

            new EntityConfiguration();
        }
    }
}
