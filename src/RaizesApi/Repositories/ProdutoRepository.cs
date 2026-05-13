using Microsoft.EntityFrameworkCore;
using RaizesApi.Data;
using RaizesApi.Interfaces;

namespace RaizesApi.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Criar(Produto produto)
        {
            await _context.Produtos.AddAsync(produto);
            var asnwer = await _context.SaveChangesAsync();
            return asnwer > 0;
        }

        public async Task<bool> CriarProdutoUnidade(ProdutoUnidade estoque)
        {
            await _context.ProdutosUnidade.AddAsync(estoque);
            var asnwer = await _context.SaveChangesAsync();
            return asnwer > 0;
        }

        public async Task<List<ProdutoUnidade>> ListarProdutos(int idUnidade)
        {
            return await _context.ProdutosUnidade
                .Where(u => u.IdUnidade == idUnidade)
                .ToListAsync();
        }
    }
}
