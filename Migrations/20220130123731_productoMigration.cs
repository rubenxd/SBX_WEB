using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SBX_WEB.Migrations
{
    public partial class productoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categorias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "estados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "marcas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marcas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    DescripcionRol = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "unidadMedidas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_unidadMedidas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DNI = table.Column<string>(nullable: true),
                    Nombres = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    Celular = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    NombreUsuario = table.Column<string>(nullable: true),
                    Contrasena = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    IdRol = table.Column<int>(nullable: false),
                    rolId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_usuarios_Rol_rolId",
                        column: x => x.rolId,
                        principalTable: "Rol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "kardexs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProducto = table.Column<int>(nullable: false),
                    Referencia = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    IVA = table.Column<float>(nullable: false),
                    IdunidadMedida = table.Column<int>(nullable: false),
                    unidadMedidaId = table.Column<int>(nullable: true),
                    Medida = table.Column<float>(nullable: false),
                    Idestado = table.Column<int>(nullable: false),
                    estadoId = table.Column<int>(nullable: true),
                    IdCategoria = table.Column<int>(nullable: false),
                    categoriaId = table.Column<int>(nullable: true),
                    Idmarca = table.Column<int>(nullable: false),
                    marcaId = table.Column<int>(nullable: true),
                    Idproveedor = table.Column<int>(nullable: false),
                    proveedorId = table.Column<int>(nullable: true),
                    ModoVenta = table.Column<string>(nullable: true),
                    StockMinimo = table.Column<int>(nullable: false),
                    StockMaximo = table.Column<int>(nullable: false),
                    Cantidad = table.Column<float>(nullable: false),
                    Costo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrecioVenta = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CodigoBarras = table.Column<string>(nullable: true),
                    SubCantidad = table.Column<float>(nullable: false),
                    ValorSubcantidad = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sobres = table.Column<int>(nullable: false),
                    ValorSobre = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Idusuario = table.Column<int>(nullable: false),
                    usuarioId = table.Column<int>(nullable: true),
                    FechaRegistro = table.Column<DateTime>(nullable: false),
                    Movimiento = table.Column<string>(nullable: true),
                    FechaVencimiento = table.Column<DateTime>(nullable: false),
                    Nota = table.Column<string>(nullable: true),
                    Accion = table.Column<string>(nullable: true),
                    UM = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kardexs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_kardexs_categorias_categoriaId",
                        column: x => x.categoriaId,
                        principalTable: "categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_kardexs_estados_estadoId",
                        column: x => x.estadoId,
                        principalTable: "estados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_kardexs_marcas_marcaId",
                        column: x => x.marcaId,
                        principalTable: "marcas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_kardexs_proveedores_proveedorId",
                        column: x => x.proveedorId,
                        principalTable: "proveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_kardexs_unidadMedidas_unidadMedidaId",
                        column: x => x.unidadMedidaId,
                        principalTable: "unidadMedidas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_kardexs_usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "productos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Referencia = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    IVA = table.Column<float>(nullable: false),
                    IdunidadMedida = table.Column<int>(nullable: false),
                    unidadMedidaId = table.Column<int>(nullable: true),
                    Medida = table.Column<float>(nullable: false),
                    Idestado = table.Column<int>(nullable: false),
                    estadoId = table.Column<int>(nullable: true),
                    IdCategoria = table.Column<int>(nullable: false),
                    categoriaId = table.Column<int>(nullable: true),
                    Idmarca = table.Column<int>(nullable: false),
                    marcaId = table.Column<int>(nullable: true),
                    Idproveedor = table.Column<int>(nullable: false),
                    proveedorId = table.Column<int>(nullable: true),
                    ModoVenta = table.Column<string>(nullable: true),
                    StockMinimo = table.Column<int>(nullable: false),
                    StockMaximo = table.Column<int>(nullable: false),
                    Cantidad = table.Column<float>(nullable: false),
                    Costo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrecioVenta = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CodigoBarras = table.Column<string>(nullable: true),
                    SubCantidad = table.Column<float>(nullable: false),
                    ValorSubcantidad = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sobres = table.Column<int>(nullable: false),
                    ValorSobre = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Idusuario = table.Column<int>(nullable: false),
                    usuarioId = table.Column<int>(nullable: true),
                    FechaRegistro = table.Column<DateTime>(nullable: false),
                    Movimiento = table.Column<string>(nullable: true),
                    FechaVencimiento = table.Column<DateTime>(nullable: false),
                    Nota = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_productos_categorias_categoriaId",
                        column: x => x.categoriaId,
                        principalTable: "categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_productos_estados_estadoId",
                        column: x => x.estadoId,
                        principalTable: "estados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_productos_marcas_marcaId",
                        column: x => x.marcaId,
                        principalTable: "marcas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_productos_proveedores_proveedorId",
                        column: x => x.proveedorId,
                        principalTable: "proveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_productos_unidadMedidas_unidadMedidaId",
                        column: x => x.unidadMedidaId,
                        principalTable: "unidadMedidas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_productos_usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_kardexs_categoriaId",
                table: "kardexs",
                column: "categoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_kardexs_estadoId",
                table: "kardexs",
                column: "estadoId");

            migrationBuilder.CreateIndex(
                name: "IX_kardexs_marcaId",
                table: "kardexs",
                column: "marcaId");

            migrationBuilder.CreateIndex(
                name: "IX_kardexs_proveedorId",
                table: "kardexs",
                column: "proveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_kardexs_unidadMedidaId",
                table: "kardexs",
                column: "unidadMedidaId");

            migrationBuilder.CreateIndex(
                name: "IX_kardexs_usuarioId",
                table: "kardexs",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_productos_categoriaId",
                table: "productos",
                column: "categoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_productos_estadoId",
                table: "productos",
                column: "estadoId");

            migrationBuilder.CreateIndex(
                name: "IX_productos_marcaId",
                table: "productos",
                column: "marcaId");

            migrationBuilder.CreateIndex(
                name: "IX_productos_proveedorId",
                table: "productos",
                column: "proveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_productos_unidadMedidaId",
                table: "productos",
                column: "unidadMedidaId");

            migrationBuilder.CreateIndex(
                name: "IX_productos_usuarioId",
                table: "productos",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_rolId",
                table: "usuarios",
                column: "rolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "kardexs");

            migrationBuilder.DropTable(
                name: "productos");

            migrationBuilder.DropTable(
                name: "categorias");

            migrationBuilder.DropTable(
                name: "estados");

            migrationBuilder.DropTable(
                name: "marcas");

            migrationBuilder.DropTable(
                name: "unidadMedidas");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "Rol");
        }
    }
}
