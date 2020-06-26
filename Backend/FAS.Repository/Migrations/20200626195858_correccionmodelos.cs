using Microsoft.EntityFrameworkCore.Migrations;

namespace FAS.Repository.Migrations
{
    public partial class correccionmodelos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Modelo_ModeloId",
                table: "Vehiculo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Modelo",
                table: "Modelo");

            migrationBuilder.RenameTable(
                name: "Modelo",
                newName: "Modelos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Modelos",
                table: "Modelos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Modelos_ModeloId",
                table: "Vehiculo",
                column: "ModeloId",
                principalTable: "Modelos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Modelos_ModeloId",
                table: "Vehiculo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Modelos",
                table: "Modelos");

            migrationBuilder.RenameTable(
                name: "Modelos",
                newName: "Modelo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Modelo",
                table: "Modelo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Modelo_ModeloId",
                table: "Vehiculo",
                column: "ModeloId",
                principalTable: "Modelo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
