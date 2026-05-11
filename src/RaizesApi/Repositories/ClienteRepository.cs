using RaizesApi.Data;
using RaizesApi.Interfaces;

namespace RaizesApi.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _context;

        public ClienteRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Criar(Cliente cliente)
        {
            await _context.AddAsync(cliente);
            var answer = await _context.SaveChangesAsync();
            return answer > 0;
        }
    }
}
