using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PUC.LDSI.Domain.Entities;

namespace PUC.LDSI.DataBase.EntityConfig
{
    public class AvaliacaoConfiguration : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            builder.Property(x => x.Materia).HasColumnType("varchar(255)").IsRequired();
            builder.Property(x => x.Disciplina).HasColumnType("varchar(255)").IsRequired();
            builder.Property(x => x.Descricao).HasColumnType("text").IsRequired();

            builder.HasOne(x => x.Professor).WithMany(x => x.Avaliacoes).HasForeignKey(x => x.ProfessorId).IsRequired();

            new EntityConfiguration();
        }
    }
}
