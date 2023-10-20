namespace Cifralite.Web.Core.Entities;

public class Secao
{
    public int? Id { get; set; }

    public string Titulo { get; set; } = string.Empty;
    public List<Acorde> Acordes { get; set; } = new();

    public Musica Musica { get; set; } = new();
    public int IdMusica { get; set; }
}

