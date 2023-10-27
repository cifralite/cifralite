using Cifralite.Web.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cifralite.Web.Core.Data.Configurations {
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder) {
            builder.ToTable("Usuarios");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(100);
            
            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Senha)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasMany(x => x.Musicas)
                .WithOne(x => x.Usuario)
                .HasConstraintName("FK_Usuario_Musica")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(x => x.Email, "IX_Usuario_Email")
                .IsUnique();
        }
    }
}