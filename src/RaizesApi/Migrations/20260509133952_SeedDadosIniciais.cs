using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RaizesApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedDadosIniciais : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "canal_pedido",
                columns: new[] { "id_canal_pedido", "descricao" },
                values: new object[,]
                {
                    { 1, "App" },
                    { 2, "Web" },
                    { 3, "Totem" }
                });

            migrationBuilder.InsertData(
                table: "status_pagamento",
                columns: new[] { "id_status_pagamento", "descricao" },
                values: new object[,]
                {
                    { 1, "Aguardando" },
                    { 2, "Pago" },
                    { 3, "Estornado" }
                });

            migrationBuilder.InsertData(
                table: "status_pedido",
                columns: new[] { "id_status_pedido", "descricao" },
                values: new object[,]
                {
                    { 1, "Pendente" },
                    { 2, "Aprovado" },
                    { 3, "Cancelado" },
                    { 4, "Entregue" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "canal_pedido",
                keyColumn: "id_canal_pedido",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "canal_pedido",
                keyColumn: "id_canal_pedido",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "canal_pedido",
                keyColumn: "id_canal_pedido",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "status_pagamento",
                keyColumn: "id_status_pagamento",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "status_pagamento",
                keyColumn: "id_status_pagamento",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "status_pagamento",
                keyColumn: "id_status_pagamento",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "status_pedido",
                keyColumn: "id_status_pedido",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "status_pedido",
                keyColumn: "id_status_pedido",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "status_pedido",
                keyColumn: "id_status_pedido",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "status_pedido",
                keyColumn: "id_status_pedido",
                keyValue: 4);
        }
    }
}
