namespace Cifralite.Web.Core.Entities;


public class Musica
{
    public int Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Artista { get; set; } = string.Empty;
    public int Tempo { get; set; }
    public List<Secao> Secoes { get; set; } = new();
}

