using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Liqui.Web.Migrations
{
    public partial class SecondDB1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioLocalId",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Local",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Address = table.Column<string>(maxLength: 80, nullable: false),
                    District = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Local", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioLocal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LocalId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioLocal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioLocal_Local_LocalId",
                        column: x => x.LocalId,
                        principalTable: "Local",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_UsuarioLocalId",
                table: "Usuarios",
                column: "UsuarioLocalId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioLocal_LocalId",
                table: "UsuarioLocal",
                column: "LocalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_UsuarioLocal_UsuarioLocalId",
                table: "Usuarios",
                column: "UsuarioLocalId",
                principalTable: "UsuarioLocal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_UsuarioLocal_UsuarioLocalId",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "UsuarioLocal");

            migrationBuilder.DropTable(
                name: "Local");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_UsuarioLocalId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "UsuarioLocalId",
                table: "Usuarios");
        }
    }
}
