using Cifralite.Web.Core.Data;
using Cifralite.Web.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cifralite.Web.Core.Services
{
    public class UsuarioService
    {
        private readonly IDbContext _context;

        public UsuarioService(IDbContext context)
        {
            _context = context;
        }

        public async Task<List<Usuario>> ObterUsuarios()
        {
            var usuarios = await _context.Usuarios.AsNoTracking().ToListAsync();
            return usuarios;
        }

        public async Task<Usuario?> ObterUsuario(int id)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
            return usuario;
        }

        public async Task<Usuario?> ObterUsusarioComSuasMusicas(int id)
        {
            var usuario = await _context.Usuarios.Include(x => x.Musicas).FirstOrDefaultAsync(x => x.Id == id);
            return usuario;
        }

        public async Task AdicionarUsuario(string nome, string email, string senha)
        {
            var usuario = new Usuario
            {
                Nome = nome,
                Email = email,
                Senha = senha
            };

            await _context.Usuarios.AddAsync(usuario);
            await _context.SaveChangesAsync();
        }

        public async Task AtualizarUsuario(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            await _context.SaveChangesAsync();
        }

        public async Task RemoverUsuario(Usuario usuario)
        {
            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
        }

    }
}