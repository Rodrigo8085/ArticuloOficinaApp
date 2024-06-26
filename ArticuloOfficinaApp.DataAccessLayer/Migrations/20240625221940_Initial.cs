using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArticuloOfficinaApp.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "articulos",
                columns: table => new
                {
                    idArticulo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "varchar", nullable: false),
                    descripcion = table.Column<string>(type: "varchar", nullable: true),
                    precio = table.Column<double>(type: "float", nullable: false),
                    imagen = table.Column<string>(type: "varchar", nullable: true),
                    stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_articulos", x => x.idArticulo);
                });

            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    idClientes = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.idClientes);
                });

            migrationBuilder.CreateTable(
                name: "tienda",
                columns: table => new
                {
                    idTienda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sucursal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tienda", x => x.idTienda);
                });

            migrationBuilder.CreateTable(
                name: "login",
                columns: table => new
                {
                    idLogin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    eMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idClientes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_login", x => x.idLogin);
                    table.ForeignKey(
                        name: "FK_login_cliente_idClientes",
                        column: x => x.idClientes,
                        principalTable: "cliente",
                        principalColumn: "idClientes",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "venta",
                columns: table => new
                {
                    idVenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    idArticulo = table.Column<int>(type: "int", nullable: false),
                    idCliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_venta", x => x.idVenta);
                    table.ForeignKey(
                        name: "FK_venta_articulos_idArticulo",
                        column: x => x.idArticulo,
                        principalTable: "articulos",
                        principalColumn: "idArticulo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_venta_cliente_idCliente",
                        column: x => x.idCliente,
                        principalTable: "cliente",
                        principalColumn: "idClientes",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tiendaArticulos",
                columns: table => new
                {
                    idTiendaArticulos = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    idArticulos = table.Column<int>(type: "int", nullable: false),
                    idTienda = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tiendaArticulos", x => x.idTiendaArticulos);
                    table.ForeignKey(
                        name: "FK_tiendaArticulos_articulos_idArticulos",
                        column: x => x.idArticulos,
                        principalTable: "articulos",
                        principalColumn: "idArticulo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tiendaArticulos_tienda_idTienda",
                        column: x => x.idTienda,
                        principalTable: "tienda",
                        principalColumn: "idTienda",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_login_idClientes",
                table: "login",
                column: "idClientes");

            migrationBuilder.CreateIndex(
                name: "IX_tiendaArticulos_idArticulos",
                table: "tiendaArticulos",
                column: "idArticulos");

            migrationBuilder.CreateIndex(
                name: "IX_tiendaArticulos_idTienda",
                table: "tiendaArticulos",
                column: "idTienda");

            migrationBuilder.CreateIndex(
                name: "IX_venta_idArticulo",
                table: "venta",
                column: "idArticulo");

            migrationBuilder.CreateIndex(
                name: "IX_venta_idCliente",
                table: "venta",
                column: "idCliente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "login");

            migrationBuilder.DropTable(
                name: "tiendaArticulos");

            migrationBuilder.DropTable(
                name: "venta");

            migrationBuilder.DropTable(
                name: "tienda");

            migrationBuilder.DropTable(
                name: "articulos");

            migrationBuilder.DropTable(
                name: "cliente");
        }
    }
}
