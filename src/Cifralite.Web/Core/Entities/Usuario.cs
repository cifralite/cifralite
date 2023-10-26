namespace Cifralite.Web.Core.Entities{
    class Usuario {
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public List<Musica> Musicas { get; set; } = new();
    }
}