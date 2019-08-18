using Microsoft.EntityFrameworkCore.Migrations;

namespace Liqui.Web.Migrations
{
    public partial class BDcondata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HojaLiquidacion_HojaProducto_HojaProductoId",
                table: "HojaLiquidacion");

            migrationBuilder.DropForeignKey(
                name: "FK_HojaLiquidacion_UsuarioLocal_UsuarioLocalId",
                table: "HojaLiquidacion");

            migrationBuilder.DropForeignKey(
                name: "FK_HojaProducto_Producto_ProductoId",
                table: "HojaProducto");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Grupo_GrupoId",
                table: "Producto");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioLocal_Local_LocalId",
                table: "UsuarioLocal");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioLocal_Usuarios_UsuarioId",
                table: "UsuarioLocal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioLocal",
                table: "UsuarioLocal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producto",
                table: "Producto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Local",
                table: "Local");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HojaProducto",
                table: "HojaProducto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HojaLiquidacion",
                table: "HojaLiquidacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grupo",
                table: "Grupo");

            migrationBuilder.RenameTable(
                name: "UsuarioLocal",
                newName: "UsuarioLocales");

            migrationBuilder.RenameTable(
                name: "Producto",
                newName: "Productos");

            migrationBuilder.RenameTable(
                name: "Local",
                newName: "Locales");

            migrationBuilder.RenameTable(
                name: "HojaProducto",
                newName: "HojaProductos");

            migrationBuilder.RenameTable(
                name: "HojaLiquidacion",
                newName: "HojaLiquidaciones");

            migrationBuilder.RenameTable(
                name: "Grupo",
                newName: "Grupos");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioLocal_UsuarioId",
                table: "UsuarioLocales",
                newName: "IX_UsuarioLocales_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioLocal_LocalId",
                table: "UsuarioLocales",
                newName: "IX_UsuarioLocales_LocalId");

            migrationBuilder.RenameIndex(
                name: "IX_Producto_GrupoId",
                table: "Productos",
                newName: "IX_Productos_GrupoId");

            migrationBuilder.RenameIndex(
                name: "IX_HojaProducto_ProductoId",
                table: "HojaProductos",
                newName: "IX_HojaProductos_ProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_HojaLiquidacion_UsuarioLocalId",
                table: "HojaLiquidaciones",
                newName: "IX_HojaLiquidaciones_UsuarioLocalId");

            migrationBuilder.RenameIndex(
                name: "IX_HojaLiquidacion_HojaProductoId",
                table: "HojaLiquidaciones",
                newName: "IX_HojaLiquidaciones_HojaProductoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioLocales",
                table: "UsuarioLocales",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productos",
                table: "Productos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locales",
                table: "Locales",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HojaProductos",
                table: "HojaProductos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HojaLiquidaciones",
                table: "HojaLiquidaciones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grupos",
                table: "Grupos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HojaLiquidaciones_HojaProductos_HojaProductoId",
                table: "HojaLiquidaciones",
                column: "HojaProductoId",
                principalTable: "HojaProductos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HojaLiquidaciones_UsuarioLocales_UsuarioLocalId",
                table: "HojaLiquidaciones",
                column: "UsuarioLocalId",
                principalTable: "UsuarioLocales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HojaProductos_Productos_ProductoId",
                table: "HojaProductos",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Grupos_GrupoId",
                table: "Productos",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioLocales_Locales_LocalId",
                table: "UsuarioLocales",
                column: "LocalId",
                principalTable: "Locales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioLocales_Usuarios_UsuarioId",
                table: "UsuarioLocales",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HojaLiquidaciones_HojaProductos_HojaProductoId",
                table: "HojaLiquidaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_HojaLiquidaciones_UsuarioLocales_UsuarioLocalId",
                table: "HojaLiquidaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_HojaProductos_Productos_ProductoId",
                table: "HojaProductos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Grupos_GrupoId",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioLocales_Locales_LocalId",
                table: "UsuarioLocales");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioLocales_Usuarios_UsuarioId",
                table: "UsuarioLocales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioLocales",
                table: "UsuarioLocales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Productos",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locales",
                table: "Locales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HojaProductos",
                table: "HojaProductos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HojaLiquidaciones",
                table: "HojaLiquidaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grupos",
                table: "Grupos");

            migrationBuilder.RenameTable(
                name: "UsuarioLocales",
                newName: "UsuarioLocal");

            migrationBuilder.RenameTable(
                name: "Productos",
                newName: "Producto");

            migrationBuilder.RenameTable(
                name: "Locales",
                newName: "Local");

            migrationBuilder.RenameTable(
                name: "HojaProductos",
                newName: "HojaProducto");

            migrationBuilder.RenameTable(
                name: "HojaLiquidaciones",
                newName: "HojaLiquidacion");

            migrationBuilder.RenameTable(
                name: "Grupos",
                newName: "Grupo");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioLocales_UsuarioId",
                table: "UsuarioLocal",
                newName: "IX_UsuarioLocal_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioLocales_LocalId",
                table: "UsuarioLocal",
                newName: "IX_UsuarioLocal_LocalId");

            migrationBuilder.RenameIndex(
                name: "IX_Productos_GrupoId",
                table: "Producto",
                newName: "IX_Producto_GrupoId");

            migrationBuilder.RenameIndex(
                name: "IX_HojaProductos_ProductoId",
                table: "HojaProducto",
                newName: "IX_HojaProducto_ProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_HojaLiquidaciones_UsuarioLocalId",
                table: "HojaLiquidacion",
                newName: "IX_HojaLiquidacion_UsuarioLocalId");

            migrationBuilder.RenameIndex(
                name: "IX_HojaLiquidaciones_HojaProductoId",
                table: "HojaLiquidacion",
                newName: "IX_HojaLiquidacion_HojaProductoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioLocal",
                table: "UsuarioLocal",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producto",
                table: "Producto",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Local",
                table: "Local",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HojaProducto",
                table: "HojaProducto",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HojaLiquidacion",
                table: "HojaLiquidacion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grupo",
                table: "Grupo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HojaLiquidacion_HojaProducto_HojaProductoId",
                table: "HojaLiquidacion",
                column: "HojaProductoId",
                principalTable: "HojaProducto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HojaLiquidacion_UsuarioLocal_UsuarioLocalId",
                table: "HojaLiquidacion",
                column: "UsuarioLocalId",
                principalTable: "UsuarioLocal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HojaProducto_Producto_ProductoId",
                table: "HojaProducto",
                column: "ProductoId",
                principalTable: "Producto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Grupo_GrupoId",
                table: "Producto",
                column: "GrupoId",
                principalTable: "Grupo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioLocal_Local_LocalId",
                table: "UsuarioLocal",
                column: "LocalId",
                principalTable: "Local",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioLocal_Usuarios_UsuarioId",
                table: "UsuarioLocal",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
