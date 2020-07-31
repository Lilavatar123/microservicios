using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Microservicios.Repositorio.Migrations
{
    public partial class EntidadProducto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Productos");

            migrationBuilder.CreateTable(
                name: "Producto",
                schema: "Productos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Referencia = table.Column<int>(nullable: false),
                    Marca = table.Column<string>(nullable: true),
                    Cantidad = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Producto",
                schema: "Productos");
        }
    }
}
