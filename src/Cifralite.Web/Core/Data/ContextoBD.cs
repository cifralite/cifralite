using Cifralite.Web.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cifralite.Web.Core.Data;

public class ContextoBD : DbContext
{
    public DbSet<Musica> Musicas { get; set; }
    public DbSet<Secao> Secoes { get; set; }

    public ContextoBD(DbContextOptions<ContextoBD> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ContextoBD).Assembly);
    }
}