
namespace Cifralite.Web.Core.Entities;

public class Acorde
{
    public string Nota { get; set; } = string.Empty;
    public string Baixo { get; set; } = string.Empty;
    public string Complemento { get; set; } = string.Empty;
    public int Tempo { get; set; }

    internal static Acorde CriarAcordePeloTexto(string acordeEmTexto)
    {
        var acorde = new Acorde();

        var notaDividida = acordeEmTexto.Split('|');

        //verificar se contem o baixo
        if (notaDividida.Length == 3)
        {
            acorde.Baixo = notaDividida[1];
            acorde.Tempo = int.Parse(notaDividida[2]);
        }
        else
        {
            acorde.Tempo = int.Parse(notaDividida[1]);
        }

        if (notaDividida[0].Contains("#"))
        {
            acorde.Nota = notaDividida[0][..2];
            acorde.Complemento = notaDividida[0][2..];
            return acorde;
        }

        acorde.Nota = notaDividida[0][..1];
        acorde.Complemento = notaDividida[0][1..];
        return acorde;
    }
}

