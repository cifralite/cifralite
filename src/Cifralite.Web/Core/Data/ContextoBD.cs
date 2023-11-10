using Cifralite.Web.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cifralite.Web.Core.Data;

public interface IDbContext
{
    public DbSet<Musica> Musicas { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Secao> Secoes { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    int SaveChanges();
}

public class AppDbContextSqlite : IdentityDbContext<Usuario, IdentityRole<int>, int>, IDbContext
{
    public AppDbContextSqlite(DbContextOptions<AppDbContextSqlite> options) : base(options)
    {
    }

    public DbSet<Musica> Musicas { get; set; } = null!;
    public DbSet<Secao> Secoes { get; set; } = null!;
    public DbSet<Usuario> Usuarios { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=../../banco.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}

public class AppDbContext : IdentityDbContext<Usuario, IdentityRole<int>, int>, IDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Musica> Musicas { get; set; } = null!;
    public DbSet<Secao> Secoes { get; set; } = null!;
    public DbSet<Usuario> Usuarios { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}