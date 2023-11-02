namespace Cifralite.Web.Core.Entities;


public class Musica
{
    public readonly static string[] Tons = new[] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

    public int Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Artista { get; set; } = string.Empty;
    public int Tempo { get; set; }
    public string? Tom { get; internal set; }
    public Usuario Usuario { get; set; } = new();

    public List<Secao> Secoes { get; set; } = new();

    public void DescerMeioTom()
    {
        if (Tom == "C")
        {
            Tom = "B";
        }
        else
        {
            Tom = Tons[Array.IndexOf(Tons, Tom) - 1];
        }

        foreach (var acorde in Secoes.SelectMany(x => x.Acordes))
        {
            acorde.DescerMeioTom();
        }
    }

    public void SubirMeioTom()
    {
        if (Tom == "B")
        {
            Tom = "C";
        }
        else
        {
            Tom = Tons[Array.IndexOf(Tons, Tom) + 1];
        }

        foreach (var acorde in Secoes.SelectMany(x => x.Acordes))
        {
            acorde.SubirMeioTom();
        }
    }
}

