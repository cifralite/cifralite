namespace Cifralite.Web.Models;

public record MusicaModel(int Id, string Titulo, string Artista, int Tempo, List<SecaoModel> Secoes);
