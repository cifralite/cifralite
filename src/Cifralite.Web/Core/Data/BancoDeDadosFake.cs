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
                    Titulo = "Deixa Eu Te Usar",
                    Artista = "Midian Lima",
                    Tempo = 160,
                    Tom = "G",
                    Secoes = new List<Secao>
                    {
                        new Secao
                        {
                            Titulo = "Introdução",
                            Acordes = new List<Acorde>
                            {
                            new Acorde {
                                    Nota = "G",
                                    Baixo = "",
                                    Complemento = "7M",
                                    Tempo = 4
                                },
                                new Acorde {
                                    Nota = "E",
                                    Baixo = "",
                                    Complemento = "m(7)9",
                                    Tempo = 4
                                },
                                new Acorde {
                                    Nota = "C",
                                    Complemento = "7M",
                                    Tempo = 2
                            },
                            new Acorde {
                                    Nota = "A",
                                    Complemento = "m7/9",
                                    Tempo = 2
                            },
                            new Acorde {
                                    Nota = "D",
                                    Complemento = "4",
                                    Tempo = 2
                            },
                             new Acorde {
                                    Nota = "D",
                                    Complemento = "4",
                                    Tempo = 2
                            },
                            }
                        },
                        new Secao
                        {
                            Titulo = "Estrofe",
                            Acordes = new List<Acorde>
                            {
                            new Acorde {
                                    Nota = "G",
                                    Baixo = "",
                                    Complemento = "7M",
                                    Tempo = 4
                                },
                                new Acorde {
                                    Nota = "E",
                                    Baixo = "",
                                    Complemento = "m(7)9",
                                    Tempo = 4
                                },
                                new Acorde {
                                    Nota = "C",
                                    Complemento = "7M",
                                    Tempo = 2
                            },
                            new Acorde {
                                    Nota = "A",
                                    Complemento = "m7/9",
                                    Tempo = 2
                            },
                            new Acorde {
                                    Nota = "D",
                                    Complemento = "4",
                                    Tempo = 2
                            },
                             new Acorde {
                                    Nota = "D",
                                    Tempo = 2
                            },
                            }
                        },
                        new Secao
                        {
                            Titulo = "Refrão",
                            Acordes = new List<Acorde>
                            {
                            new Acorde {
                                    Nota = "G",
                                    Baixo = "",
                                    Complemento = "7M",
                                    Tempo = 4
                                },
                                new Acorde {
                                    Nota = "E",
                                    Baixo = "",
                                    Complemento = "m(7)9",
                                    Tempo = 4
                                },
                                new Acorde {
                                    Nota = "C",
                                    Complemento = "7M",
                                    Tempo = 2
                            },
                            new Acorde {
                                    Nota = "G",
                                    Baixo = "B",
                                    Tempo = 2
                            },
                            new Acorde {
                                    Nota = "A",
                                    Complemento = "m7/9",
                                    Tempo = 2
                            },
                            new Acorde {
                                    Nota = "D",
                                    Complemento = "4",
                                    Tempo = 2
                            },
                             new Acorde {
                                    Nota = "D",
                                    Baixo = "C",
                                    Complemento = "7",
                                    Tempo = 2
                            },

                            }
                        },
                        new Secao
                        {
                            Titulo = "Solo",
                            Acordes = new List<Acorde>
                            {
                            new Acorde {
                                    Nota = "G",
                                    Baixo = "",
                                    Complemento = "7M",
                                    Tempo = 4
                                },
                                new Acorde {
                                    Nota = "E",
                                    Baixo = "",
                                    Complemento = "m(7)9",
                                    Tempo = 4
                                },
                                new Acorde {
                                    Nota = "C",
                                    Complemento = "7M",
                                    Tempo = 2
                            },
                            new Acorde {
                                    Nota = "A",
                                    Complemento = "m7/9",
                                    Tempo = 2
                            },
                            new Acorde {
                                    Nota = "D",
                                    Complemento = "4",
                                    Tempo = 2
                            },
                             new Acorde {
                                    Nota = "D",
                                    Tempo = 2
                            },
                            }
                        },
                         new Secao
                        {
                            Titulo = "Ponte",
                            Acordes = new List<Acorde>
                            {
                                new Acorde {
                                        Nota = "F#",
                                        Complemento = "m",
                                        Tempo = 2
                                    },
                                    new Acorde {
                                        Nota = "D",
                                        Tempo = 2
                                    },
                                    new Acorde {
                                        Nota = "A",
                                        Baixo = "C#",
                                        Tempo = 2
                                },
                                new Acorde {
                                        Nota = "E",
                                        Baixo = "G#",
                                        Tempo = 2
                                },
                                new Acorde {
                                        Nota = "F#",
                                        Complemento = "m",
                                        Tempo = 2
                                    },
                                    new Acorde {
                                        Nota = "D",
                                        Tempo = 2
                                    },
                                    new Acorde {
                                        Nota = "A",
                                        Baixo = "C#",
                                        Tempo = 2
                                },
                                new Acorde {
                                        Nota = "E",
                                        Baixo = "",
                                        Complemento = "7",
                                        Tempo = 2
                                }
                            }
                        },
                        new Secao
                        {
                            Titulo = "Refrão (Tom Novo)",
                            Acordes = new List<Acorde>
                            {
                            new Acorde {
                                    Nota = "A",
                                    Tempo = 4
                                },
                                new Acorde {
                                    Nota = "F#",
                                    Complemento = "m7/9",
                                    Tempo = 4
                                },
                                new Acorde {
                                    Nota = "D",
                                    Complemento = "7M",
                                    Tempo = 2
                            },
                            new Acorde {
                                    Nota = "B",
                                    Complemento = "m7/9",
                                    Tempo = 2
                            },
                            new Acorde {
                                    Nota = "E",
                                    Complemento = "4",
                                    Tempo = 2
                            },
                             new Acorde {
                                    Nota = "E",
                                    Tempo = 2
                            },
                            }
                        },
                    },
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
                                        Tempo = 4
                                    },
                                    new Acorde {
                                        Nota = "G",
                                        Baixo = "",
                                        Complemento = "9",
                                        Tempo = 4
                                    },
                                    new Acorde {
                                        Nota = "Am",
                                        Baixo = "C",
                                        Complemento = "7M",
                                        Tempo = 4
                                }
                            }
                        }
                    },
                    Tom = "C"
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
                                    Tempo = 4
                                },
                                new Acorde {
                                    Nota = "B",
                                    Baixo = "",
                                    Complemento = "9",
                                    Tempo = 4
                                },
                                new Acorde {
                                    Nota = "F",
                                    Baixo = "C",
                                    Complemento = "7M",
                                    Tempo = 4
                            }
                            }
                        },
                        new Secao
                        {
                            Titulo = "Refrão",
                            Acordes = new List<Acorde>
                            {
                            new Acorde {
                                    Nota = "E",
                                    Baixo = "",
                                    Complemento = "7M",
                                    Tempo = 4
                                },
                                new Acorde {
                                    Nota = "B",
                                    Baixo = "",
                                    Complemento = "9",
                                    Tempo = 4
                                },
                                new Acorde {
                                    Nota = "E",
                                    Baixo = "",
                                    Complemento = "",
                                    Tempo = 4
                                },
                                new Acorde {
                                    Nota = "F",
                                    Baixo = "",
                                    Complemento = "",
                                    Tempo = 4
                                },
                                new Acorde {
                                    Nota = "F",
                                    Baixo = "C",
                                    Complemento = "7M",
                                    Tempo = 4
                            }
                            }
                        }
                    },
                    Tom = "C"
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

        public static void Update(Musica musica)
        {
            var MusicaAntiga = Musicas.First(x => x.Id == musica.Id);
            var index = Musicas.IndexOf(MusicaAntiga);
            Musicas[index] = musica;
        } 
    }
}