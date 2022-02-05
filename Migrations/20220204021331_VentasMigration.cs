using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SBX_WEB.Migrations
{
    public partial class VentasMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "DescuentoP",
                table: "productos",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateTable(
                name: "ventas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(nullable: false),
                    NombreDocumento = table.Column<string>(nullable: true),
                    ConsecutivoDocumento = table.Column<string>(nullable: true),
                    ProductoId = table.Column<int>(nullable: false),
                    ModoVenta = table.Column<string>(nullable: true),
                    UM = table.Column<string>(nullable: true),
                    Cantidad = table.Column<int>(nullable: false),
                    Costo = table.Column<float>(nullable: false),
                    PrecioVenta = table.Column<float>(nullable: false),
                    Descuento = table.Column<float>(nullable: false),
                    Efectivo = table.Column<float>(nullable: false),
                    Cambio = table.Column<float>(nullable: false),
                    Total = table.Column<float>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false),
                    IVA = table.Column<float>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false),
                    Nota = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ventas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ventas_clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ventas_productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ventas_ClienteId",
                table: "ventas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ventas_ProductoId",
                table: "ventas",
                column: "ProductoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ventas");

            migrationBuilder.DropColumn(
                name: "DescuentoP",
                table: "productos");
        }
    }
}
