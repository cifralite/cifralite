
using Cifralite.Web.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cifralite.Web.Core.Data.Configurations;

public class MusicaConfig : IEntityTypeConfiguration<Musica>
{
    public void Configure(EntityTypeBuilder<Musica> builder)
    {
        builder.ToTable("Musicas");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Titulo)
            .IsRequired();

        builder.Property(x => x.Artista)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.Tempo);

        builder.Property(x => x.Tom)
            .HasMaxLength(2);

        builder.HasMany(x => x.Secoes)
            .WithOne(x => x.Musica)
            .HasForeignKey(x => x.IdMusica)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
