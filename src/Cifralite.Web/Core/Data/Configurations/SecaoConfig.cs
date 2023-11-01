using Cifralite.Web.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cifralite.Web.Core.Data.Configurations;

public class SecaoConfig : IEntityTypeConfiguration<Secao>
{
    public void Configure(EntityTypeBuilder<Secao> builder)
    {
        builder.ToTable("Secoes");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Titulo)
            .IsRequired()
            .HasMaxLength(100);

        var conversor =
            new ValueConverter<List<Acorde>, string>(
            acordes => string.Join(" ", Acorde.TransformarAcordesEmTexto(acordes)),
            acordes => acordes.Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(Acorde.CriarAcordePeloTexto).ToList());

        var comparer =
            new ValueComparer<List<Acorde>>(
            (a1, a2) => a1!.SequenceEqual(a2!),
            a => a.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
            a => a.ToList()
        );

        builder
            .Property(x => x.Acordes)
            .HasConversion(conversor)
            .Metadata.SetValueComparer(comparer);

        builder.HasOne(x => x.Musica)
            .WithMany(x => x.Secoes)
            .HasForeignKey(x => x.IdMusica)
            .OnDelete(DeleteBehavior.Cascade);
    }
}