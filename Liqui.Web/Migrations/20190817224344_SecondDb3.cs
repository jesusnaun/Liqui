using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Liqui.Web.Migrations
{
    public partial class SecondDb3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HojaLiquidacion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UsuarioLocalId = table.Column<int>(nullable: true),
                    MyDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HojaLiquidacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HojaLiquidacion_UsuarioLocal_UsuarioLocalId",
                        column: x => x.UsuarioLocalId,
                        principalTable: "UsuarioLocal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HojaLiquidacion_UsuarioLocalId",
                table: "HojaLiquidacion",
                column: "UsuarioLocalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HojaLiquidacion");
        }
    }
}
