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

        public async Task<Usuario?> ObterUsusario(int id) {
            var usuario = await _contextoBD.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
            return usuario;
        }

        public async Task<Usuario?> ObterUsusarioComSuasMusicas(int id) {
            var usuario = await _contextoBD.Usuarios.Include(x => x.Musicas).FirstOrDefaultAsync(x => x.Id == id);
            return usuario;
        }

    }
}