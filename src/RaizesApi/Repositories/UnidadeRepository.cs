using RaizesApi.Data;
using RaizesApi.Interfaces;

namespace RaizesApi.Repositories
{
    public class UnidadeRepository : IUnidadeRepository
    {

        private readonly AppDbContext _context;
        public UnidadeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Criar(Unidade unidade)
        {
            await _context.AddAsync(unidade);
            var answer = await _context.SaveChangesAsync();
            return answer > 0;
        }
    }
}
