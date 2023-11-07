using System.Text.RegularExpressions;
using Cifralite.Web.Core.Data;
using Cifralite.Web.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cifralite.Web.Core.Services
{
    public class MusicaService
    {
        private readonly IDbContext _context;

        public MusicaService(IDbContext context)
        {
            _context = context;
        }

        public async Task<List<Musica>> ObterMusicas()
        {
            var musicas = await _context.Musicas.AsNoTracking().ToListAsync();
            return musicas;
        }

        public async Task<Musica?> ObterMusicaPeloId(int id)
        {
            var musica = await _context.Musicas.Include(x => x.Secoes).FirstOrDefaultAsync(x => x.Id == id);
            return musica;
        }

        public async Task<int> AdicionarMusica(string titulo, string tom, int tempo, string musicaEmTexto)
        {
            var musica = new Musica
            {
                Titulo = titulo,
                Tom = tom,
                Tempo = tempo,
                Artista = "Desconhecido"
            };

            foreach (var secao in FormatarMusicaParaObjetos(musicaEmTexto))
            {
                musica.Secoes.Add(secao);
            }
            await _context.Musicas.AddAsync(musica);
            await _context.SaveChangesAsync();

            return musica.Id;
        }

        public List<Secao> FormatarMusicaParaObjetos(string musicaEmTexto)
        {
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

        public async Task RemoverMusica(int id)
        {
            var musica = await _context.Musicas.FirstOrDefaultAsync(x => x.Id == id);

            if (musica is not null)
            {
                _context.Musicas.Remove(musica);
            }

            await _context.SaveChangesAsync();
        }

        public async Task AtualizarMusica(Musica musicaEditada, string musicaEmTexto)
        {
            musicaEditada.Secoes = FormatarMusicaParaObjetos(musicaEmTexto);
            _context.Musicas.Update(musicaEditada);
            await _context.SaveChangesAsync();
        }
    }
}