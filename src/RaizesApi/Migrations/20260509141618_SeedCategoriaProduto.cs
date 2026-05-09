using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RaizesApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategoriaProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categoria_produto",
                columns: new[] { "id_categoria_produto", "descricao" },
                values: new object[,]
                {
                    { 1, "Bebidas" },
                    { 2, "Comida" },
                    { 3, "Sobremesa" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "categoria_produto",
                keyColumn: "id_categoria_produto",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "categoria_produto",
                keyColumn: "id_categoria_produto",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "categoria_produto",
                keyColumn: "id_categoria_produto",
                keyValue: 3);
        }
    }
}
