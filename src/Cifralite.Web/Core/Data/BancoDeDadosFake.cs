using Cifralite.Web.Core.Entities;

namespace Cifralite.Web.Core.Services
{
    public static class BancoDeDadosFake
    {
        public static List<Musica> Musicas = new List<Musica>();

        static BancoDeDadosFake()
        {
            Musicas.AddRange(new List<Musica>
            {
                new Musica
                {
                    Id = 1,
                    Titulo = "Deixa eu te usar",
                    Artista = "Midian Lima",
                    Tempo = 90,
                    Secoes = new List<Secao>
                    {
                        new Secao
                        {
                            Titulo = "Intro",
                            Acordes = new List<Acorde>
                            {
                            new Acorde {
                                    Nota = "C",
                                    Baixo = "",
                                    Complemento = "7M",
                                    Tempo = 8
                                },
                                new Acorde {
                                    Nota = "G",
                                    Baixo = "",
                                    Complemento = "9",
                                    Tempo = 8
                                },
                                new Acorde {
                                    Nota = "Am",
                                    Baixo = "C",
                                    Complemento = "7M",
                                    Tempo = 8
                            }
                            }
                        }
                    }
                },
                new Musica
                {
                    Id = 2,
                    Titulo = "Deus e eu",
                    Artista = "Leandro Borges",
                    Tempo = 90,
                    Secoes = new List<Secao>
                    {
                        new Secao
                        {
                            Titulo = "Intro",
                            Acordes = new List<Acorde>
                            {
                            new Acorde {
                                    Nota = "C",
                                    Baixo = "",
                                    Complemento = "7M",
                                    Tempo = 8
                                },
                                new Acorde {
                                    Nota = "G",
                                    Baixo = "",
                                    Complemento = "9",
                                    Tempo = 8
                                },
                                new Acorde {
                                    Nota = "Am",
                                    Baixo = "C",
                                    Complemento = "7M",
                                    Tempo = 8
                            }
                            }
                        }
                    }
                },
                new Musica
                {
                    Id = 3,
                    Titulo = "Só quero ver você",
                    Artista = "Laura Souguellis",
                    Tempo = 90,
                    Secoes = new List<Secao>
                    {
                        new Secao
                        {
                            Titulo = "Intro",
                            Acordes = new List<Acorde>
                            {
                            new Acorde {
                                    Nota = "E",
                                    Baixo = "",
                                    Complemento = "7M",
                                    Tempo = 8
                                },
                                new Acorde {
                                    Nota = "B",
                                    Baixo = "",
                                    Complemento = "9",
                                    Tempo = 8
                                },
                                new Acorde {
                                    Nota = "F",
                                    Baixo = "C",
                                    Complemento = "7M",
                                    Tempo = 8
                            }
                            }
                        }
                    }
                },
            });
        }

        public static List<Musica> List()
        {
            return Musicas;
        }

        public static Musica? GetById(int id)
        {
            return Musicas.FirstOrDefault(m => m.Id == id);
        }

        public static void Add(Musica musica)
        {
            musica.Id = Musicas.Max(m => m.Id) + 1;
            Musicas.Add(musica);
        }

        public static void Remove(int id)
        {
            Musicas.RemoveAll(m => m.Id == id);
        }
    }
}