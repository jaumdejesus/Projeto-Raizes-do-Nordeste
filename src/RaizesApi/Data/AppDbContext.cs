using Microsoft.EntityFrameworkCore;

namespace RaizesApi.Data
{
    public class AppDbContext : DbContext
    {        
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<StatusPedido> StatusPedidos { get; set; }
        public DbSet<StatusPagamento> StatusPagamentos { get; set; }
        public DbSet<CanalPedido> CanalPedidos { get; set; }
        public DbSet<Unidade> Unidades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<CategoriaProduto> CategoriasProduto { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoUnidade> ProdutosUnidade { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedido { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
