using Cifralite.Web.Models;

namespace Cifralite.Web.Services
{
    public class MusicaService
    {
        public List<MusicaModel> Musicas
        {
            get
            {
                var listaDeMusicas = new List<MusicaModel>
                {
                    new(1, "Deixa eu te usar", "Midian Lima", 90, new List<SecaoModel>
                    {
                        new SecaoModel("Intro",
                        new List<AcordeModel> {
                            new AcordeModel("C","", "7M", 8),
                            new AcordeModel("G","", "7M", 8),
                            new AcordeModel("Am","", "7M", 8),
                        }),
                        })
                    };
                return listaDeMusicas;
            }
        }

        public List<MusicaModel>? ObterMusicas()
        {
            return Musicas;
        }
    }
}