namespace Cifralite.Web.Core.Entities;

public class Secao
{
    public string Titulo { get; set; } = string.Empty;
    public List<Acorde> Acordes { get; set; } = new();
}

