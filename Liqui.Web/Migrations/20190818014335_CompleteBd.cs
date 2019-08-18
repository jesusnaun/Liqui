using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Liqui.Web.Migrations
{
    public partial class CompleteBd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AmericanExpress",
                table: "HojaLiquidacion",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DinersClub",
                table: "HojaLiquidacion",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Efectivo",
                table: "HojaLiquidacion",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "HojaProductoId",
                table: "HojaLiquidacion",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "InsumoPorProcesar",
                table: "HojaLiquidacion",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "InsumoSinProcesar",
                table: "HojaLiquidacion",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MasterCredito",
                table: "HojaLiquidacion",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MasterDebito",
                table: "HojaLiquidacion",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "NoInsumo",
                table: "HojaLiquidacion",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "OtrosE",
                table: "HojaLiquidacion",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "OtrosI",
                table: "HojaLiquidacion",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PersonalE",
                table: "HojaLiquidacion",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PersonalI",
                table: "HojaLiquidacion",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalEgresos",
                table: "HojaLiquidacion",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalIngresos",
                table: "HojaLiquidacion",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "UtilidadBruta",
                table: "HojaLiquidacion",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "UtilidadEfetivo",
                table: "HojaLiquidacion",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "VisaCredito",
                table: "HojaLiquidacion",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "VisaDebito",
                table: "HojaLiquidacion",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Grupo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    GrupoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Producto_Grupo_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HojaProducto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Inicial = table.Column<decimal>(nullable: false),
                    Entrada = table.Column<decimal>(nullable: false),
                    Venta = table.Column<decimal>(nullable: false),
                    Final = table.Column<decimal>(nullable: false),
                    Observaciones = table.Column<string>(nullable: true),
                    ProductoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HojaProducto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HojaProducto_Producto_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Producto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HojaLiquidacion_HojaProductoId",
                table: "HojaLiquidacion",
                column: "HojaProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_HojaProducto_ProductoId",
                table: "HojaProducto",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_GrupoId",
                table: "Producto",
                column: "GrupoId");

            migrationBuilder.AddForeignKey(
                name: "FK_HojaLiquidacion_HojaProducto_HojaProductoId",
                table: "HojaLiquidacion",
                column: "HojaProductoId",
                principalTable: "HojaProducto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HojaLiquidacion_HojaProducto_HojaProductoId",
                table: "HojaLiquidacion");

            migrationBuilder.DropTable(
                name: "HojaProducto");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Grupo");

            migrationBuilder.DropIndex(
                name: "IX_HojaLiquidacion_HojaProductoId",
                table: "HojaLiquidacion");

            migrationBuilder.DropColumn(
                name: "AmericanExpress",
                table: "HojaLiquidacion");

            migrationBuilder.DropColumn(
                name: "DinersClub",
                table: "HojaLiquidacion");

            migrationBuilder.DropColumn(
                name: "Efectivo",
                table: "HojaLiquidacion");

            migrationBuilder.DropColumn(
                name: "HojaProductoId",
                table: "HojaLiquidacion");

            migrationBuilder.DropColumn(
                name: "InsumoPorProcesar",
                table: "HojaLiquidacion");

            migrationBuilder.DropColumn(
                name: "InsumoSinProcesar",
                table: "HojaLiquidacion");

            migrationBuilder.DropColumn(
                name: "MasterCredito",
                table: "HojaLiquidacion");

            migrationBuilder.DropColumn(
                name: "MasterDebito",
                table: "HojaLiquidacion");

            migrationBuilder.DropColumn(
                name: "NoInsumo",
                table: "HojaLiquidacion");

            migrationBuilder.DropColumn(
                name: "OtrosE",
                table: "HojaLiquidacion");

            migrationBuilder.DropColumn(
                name: "OtrosI",
                table: "HojaLiquidacion");

            migrationBuilder.DropColumn(
                name: "PersonalE",
                table: "HojaLiquidacion");

            migrationBuilder.DropColumn(
                name: "PersonalI",
                table: "HojaLiquidacion");

            migrationBuilder.DropColumn(
                name: "TotalEgresos",
                table: "HojaLiquidacion");

            migrationBuilder.DropColumn(
                name: "TotalIngresos",
                table: "HojaLiquidacion");

            migrationBuilder.DropColumn(
                name: "UtilidadBruta",
                table: "HojaLiquidacion");

            migrationBuilder.DropColumn(
                name: "UtilidadEfetivo",
                table: "HojaLiquidacion");

            migrationBuilder.DropColumn(
                name: "VisaCredito",
                table: "HojaLiquidacion");

            migrationBuilder.DropColumn(
                name: "VisaDebito",
                table: "HojaLiquidacion");
        }
    }
}
