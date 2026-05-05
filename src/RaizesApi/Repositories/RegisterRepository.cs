using RaizesApi.Data;
using RaizesApi.Interfaces;
using RaizesApi.Models;

namespace RaizesApi.Repositories
{
    public class RegisterRepository : IRegisterRepository
    {
        private readonly AppDbContext _context;

        public RegisterRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Register(UsuarioLogin user)
        {
            await _context.UsuarioLogin.AddAsync(user);
            int answer = await _context.SaveChangesAsync();
            return answer > 0;
        }        
    }
}
