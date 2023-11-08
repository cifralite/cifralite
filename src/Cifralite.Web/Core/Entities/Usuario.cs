using Microsoft.AspNetCore.Identity;

namespace Cifralite.Web.Core.Entities{
    public class Usuario{
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public List<Musica> Musicas { get; set; } = new();
    }
}