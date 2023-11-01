using Cifralite.Web.Core.Data;
using Cifralite.Web.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cifralite.Web.Core.Services {
    public class UsuarioService {
        private readonly ContextoBD _contextoBD;

        public UsuarioService(ContextoBD contextoBD)
        {
            _contextoBD = contextoBD;
        }

        public async Task<List<Usuario>> ObterUsuarios() {
            var usuarios = await _contextoBD.Usuarios.AsNoTracking().ToListAsync();
            return usuarios;
        }

        public async Task<Usuario?> ObterUsuario(int id) {
            var usuario = await _contextoBD.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
            return usuario;
        }

        public async Task<Usuario?> ObterUsusarioComSuasMusicas(int id) {
            var usuario = await _contextoBD.Usuarios.Include(x => x.Musicas).FirstOrDefaultAsync(x => x.Id == id);
            return usuario;
        }

        public async Task AdicionarUsuario(string nome, string email, string senha) {
            var usuario = new Usuario() {
                Nome = nome,
                Email = email,
                Senha = senha
            };

            await _contextoBD.Usuarios.AddAsync(usuario);
            await _contextoBD.SaveChangesAsync();
        }

        public async Task AtualizarUsuario(Usuario usuario) {
            _contextoBD.Usuarios.Update(usuario);
            await _contextoBD.SaveChangesAsync();
        }

        public async Task RemoverUsuario(Usuario usuario) {
            _contextoBD.Usuarios.Remove(usuario);
            await _contextoBD.SaveChangesAsync();
        }

    }
}