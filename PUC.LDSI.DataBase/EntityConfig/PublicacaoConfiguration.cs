using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUC.LDSI.Domain.Entities;

namespace PUC.LDSI.DataBase.EntityConfig
{
    public class PublicacaoConfiguration : IEntityTypeConfiguration<Publicacao>
    {
        public void Configure(EntityTypeBuilder<Publicacao> builder)
        {
            builder.Property(x => x.DataInicio).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.DataFim).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.ValorProva).HasColumnType("int").IsRequired();

            builder.HasOne(x => x.Turma).WithMany(x => x.Publicacoes).HasForeignKey(x => x.TurmaId).IsRequired();
            builder.HasOne(x => x.Avaliacao).WithMany(x => x.Publicacoes).HasForeignKey(x => x.AvaliacaoId).IsRequired();

            new EntityConfiguration();
        }
    }
}
