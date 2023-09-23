using Microsoft.AspNetCore.Mvc.RazorPages;
using Cifralite.Web.Services;
using Cifralite.Web.Models;

namespace Cifralite.Web.Pages;

public class IndexModel : PageModel
{
    public List<MusicaModel>? Musicas { get; set; } = new();

    public IndexModel() { }

    public void OnGet()
    {
        var service = new MusicaService();
        Musicas = service.ObterMusicas();
    }
}

