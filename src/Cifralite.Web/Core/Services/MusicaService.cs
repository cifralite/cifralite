using Cifralite.Web.Core.Entities;

namespace Cifralite.Web.Core.Services
{
    public class MusicaService
    {
        public List<Musica> ObterMusicas()
        {
            return BancoDeDadosFake.Musicas;
        }
    }
}