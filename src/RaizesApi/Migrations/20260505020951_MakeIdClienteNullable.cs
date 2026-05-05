using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RaizesApi.Migrations
{
    /// <inheritdoc />
    public partial class MakeIdClienteNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_usuario_login_cliente_id_cliente",
                table: "usuario_login");

            migrationBuilder.AlterColumn<int>(
                name: "id_cliente",
                table: "usuario_login",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_usuario_login_cliente_id_cliente",
                table: "usuario_login",
                column: "id_cliente",
                principalTable: "cliente",
                principalColumn: "id_cliente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_usuario_login_cliente_id_cliente",
                table: "usuario_login");

            migrationBuilder.AlterColumn<int>(
                name: "id_cliente",
                table: "usuario_login",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_usuario_login_cliente_id_cliente",
                table: "usuario_login",
                column: "id_cliente",
                principalTable: "cliente",
                principalColumn: "id_cliente",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
