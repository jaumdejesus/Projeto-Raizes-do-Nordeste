using Microsoft.EntityFrameworkCore;
using RaizesApi;

namespace RaizesApi.Data
{
    public static class DataSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StatusPedido>().HasData(
                new StatusPedido { IdStatusPedido = 1, Descricao = "Pendente" },
                new StatusPedido { IdStatusPedido = 2, Descricao = "Aprovado" },
                new StatusPedido { IdStatusPedido = 3, Descricao = "Cancelado" },
                new StatusPedido { IdStatusPedido = 4, Descricao = "Entregue" }
            );
            
            modelBuilder.Entity<StatusPagamento>().HasData(
                new StatusPagamento { IdStatusPagamento = 1, Descricao = "Aguardando" },
                new StatusPagamento { IdStatusPagamento = 2, Descricao = "Pago" },
                new StatusPagamento { IdStatusPagamento = 3, Descricao = "Estornado" }
            );
            
            modelBuilder.Entity<CanalPedido>().HasData(
                new CanalPedido { IdCanalPedido = 1, Descricao = "App" },
                new CanalPedido { IdCanalPedido = 2, Descricao = "Web" },
                new CanalPedido { IdCanalPedido = 3, Descricao = "Totem" }
            );
        }
        
    }
}
