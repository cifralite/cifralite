using System.Text.RegularExpressions;
using Cifralite.Web.Core.Entities;

namespace Cifralite.Web.Core.Services
{
    public class MusicaService
    {
        public List<Musica> ObterMusicas()
        {
            return BancoDeDadosFake.Musicas;
        }

        public int AdicionarMusica(string titulo, string tom, int tempo, string musicaEmTexto)
        {
            var musica = new Musica
            {
                Titulo = titulo,
                Tom = tom,
                Tempo = tempo,
                Artista = "Desconhecido"
            };

            var secoes = new List<Secao>();

            var linhas = musicaEmTexto.Split('\n');

            Secao? secao = null;

            foreach (var linha in linhas)
            {
                if (string.IsNullOrEmpty(linha))
                {
                    continue;
                }

                var conteudoEntreColchetesRegex = @"^\[([^/].*)\]$";
                var conteudoEntreColchetesComBarraRegex = @"^\[\/(.+)\]$";

                //verifica se está dentro do padrão de inicio de uma secao, exemplo: [intro]
                // se estiver, pega o conteudo entre os colchetes
                var inicioDaSecao = Regex.Match(linha, conteudoEntreColchetesRegex);
                if (inicioDaSecao.Success)
                {
                    var nomeDaSecao = inicioDaSecao.Groups[1].Value;
                    secao = new Secao { Titulo = nomeDaSecao };
                    continue;
                }

                //verifica se está dentro do padrão de fim de uma secao, exemplo: [/intro]
                // se estiver, salva a secao na musica e vai para proxima linha

                var fimDaSecao = Regex.Match(linha, conteudoEntreColchetesComBarraRegex);
                if (fimDaSecao.Success)
                {
                    if (secao is not null)
                    {
                        secoes.Add(secao);
                    }
                    secao = null;
                    continue;
                }

                // o que não é inicio/fim de seção deve ser acorde
                if (secao is not null)
                {
                    var acordesEmTexto = linha.Trim().Split(' ');
                    foreach (var acordeEmTexto in acordesEmTexto)
                    {
                        var acorde = Acorde.CriarAcordePeloTexto(acordeEmTexto);
                        secao.Acordes.Add(acorde);
                    }
                }
            }

            musica.Secoes = secoes;
            BancoDeDadosFake.Add(musica);
            return musica.Id;
        }

        public List<Secao> FormatarMusicaParaObjetos(string musicaEmTexto) {
            var secoes = new List<Secao>();

            var linhas = musicaEmTexto.Split('\n');

            Secao? secao = null;

            foreach (var linha in linhas)
            {
                if (string.IsNullOrEmpty(linha))
                {
                    continue;
                }

                var conteudoEntreColchetesRegex = @"^\[([^/].*)\]$";
                var conteudoEntreColchetesComBarraRegex = @"^\[\/(.+)\]$";

                //verifica se está dentro do padrão de inicio de uma secao, exemplo: [intro]
                // se estiver, pega o conteudo entre os colchetes
                var inicioDaSecao = Regex.Match(linha, conteudoEntreColchetesRegex);
                if (inicioDaSecao.Success)
                {
                    var nomeDaSecao = inicioDaSecao.Groups[1].Value;
                    secao = new Secao { Titulo = nomeDaSecao };
                    continue;
                }

                //verifica se está dentro do padrão de fim de uma secao, exemplo: [/intro]
                // se estiver, salva a secao na musica e vai para proxima linha

                var fimDaSecao = Regex.Match(linha, conteudoEntreColchetesComBarraRegex);
                if (fimDaSecao.Success)
                {
                    if (secao is not null)
                    {
                        secoes.Add(secao);
                    }
                    secao = null;
                    continue;
                }

                // o que não é inicio/fim de seção deve ser acorde
                if (secao is not null)
                {
                    var acordesEmTexto = linha.Trim().Split(' ');
                    foreach (var acordeEmTexto in acordesEmTexto)
                    {
                        var acorde = Acorde.CriarAcordePeloTexto(acordeEmTexto);
                        secao.Acordes.Add(acorde);
                    }
                }
            }
            return secoes;
        }

        public void RemoverMusica(int id) {
            BancoDeDadosFake.Remove(id);
        }

        public void AtualizarMusica(int id, string titulo, string tom, int tempo, string musicaEmTexto) {
            Musica? MusicaAntiga = BancoDeDadosFake.GetById(id);
            MusicaAntiga.Titulo = titulo;
            MusicaAntiga.Tom = tom;
            MusicaAntiga.Tempo = tempo;
            MusicaAntiga.Secoes = FormatarMusicaParaObjetos(musicaEmTexto);
            BancoDeDadosFake.Update(id, MusicaAntiga);
        } 
    }
}