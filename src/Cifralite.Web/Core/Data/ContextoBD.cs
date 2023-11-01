using Cifralite.Web.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cifralite.Web.Core.Data;

public interface IDbContext
{
    public DbSet<Musica> Musicas { get; set; }
    public DbSet<Secao> Secoes { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    int SaveChanges();
}

public class AppDbContextSqlite : DbContext, IDbContext
{
    public AppDbContextSqlite(DbContextOptions<AppDbContextSqlite> options) : base(options) { }

    public DbSet<Musica> Musicas { get; set; }
    public DbSet<Secao> Secoes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=../../banco.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}

public class AppDbContext : DbContext, IDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Musica> Musicas { get; set; }
    public DbSet<Secao> Secoes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}