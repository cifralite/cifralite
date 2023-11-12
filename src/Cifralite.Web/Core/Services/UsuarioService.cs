using Cifralite.Web.Core.Data;
using Cifralite.Web.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Cifralite.Web.Core.Services
{
    public class UsuarioService
    {
        private readonly IDbContext _context;
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;

        public UsuarioService(IDbContext context, UserManager<Usuario> userManager, SignInManager<Usuario> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
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
                UserName = nome,
                Email = email,
                Senha = senha
            };

            await _userManager.CreateAsync(usuario, senha);

            // await _context.Usuarios.AddAsync(usuario);
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

        public async Task<bool> Login(string email, string senha) 
        {
            var usuario = await _userManager.FindByEmailAsync(email);

            if (usuario != null) {
                var resultado = await _signInManager.CheckPasswordSignInAsync(usuario, senha, false);
                if (resultado.Succeeded) {
                    return true;
                } else {
                    return false;
                }
            } else {
                return false;
            }
        }

    }
}