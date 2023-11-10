using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Cifralite.Web.Core.Entities{
    public class Usuario : IdentityUser<int>{
        public string Nome { get; set; } = string.Empty;
        // [Required(ErrorMessage = "A senha é obrigatória")]
        public string Senha { get; set; } = string.Empty;
        public List<Musica> Musicas { get; set; } = new();
    }
}