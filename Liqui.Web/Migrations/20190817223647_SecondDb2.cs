using Microsoft.EntityFrameworkCore.Migrations;

namespace Liqui.Web.Migrations
{
    public partial class SecondDb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_UsuarioLocal_UsuarioLocalId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_UsuarioLocalId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "UsuarioLocalId",
                table: "Usuarios");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "UsuarioLocal",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioLocal_UsuarioId",
                table: "UsuarioLocal",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioLocal_Usuarios_UsuarioId",
                table: "UsuarioLocal",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioLocal_Usuarios_UsuarioId",
                table: "UsuarioLocal");

            migrationBuilder.DropIndex(
                name: "IX_UsuarioLocal_UsuarioId",
                table: "UsuarioLocal");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "UsuarioLocal");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioLocalId",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_UsuarioLocalId",
                table: "Usuarios",
                column: "UsuarioLocalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_UsuarioLocal_UsuarioLocalId",
                table: "Usuarios",
                column: "UsuarioLocalId",
                principalTable: "UsuarioLocal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
