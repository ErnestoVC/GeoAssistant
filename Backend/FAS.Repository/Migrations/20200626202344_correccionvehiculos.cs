using Microsoft.EntityFrameworkCore.Migrations;

namespace FAS.Repository.Migrations
{
    public partial class correccionvehiculos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Modelos_ModeloId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Viaje_Vehiculo_VehiculoId",
                table: "Viaje");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehiculo",
                table: "Vehiculo");

            migrationBuilder.RenameTable(
                name: "Vehiculo",
                newName: "Vehiculos");

            migrationBuilder.RenameIndex(
                name: "IX_Vehiculo_ModeloId",
                table: "Vehiculos",
                newName: "IX_Vehiculos_ModeloId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehiculos",
                table: "Vehiculos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Modelos_ModeloId",
                table: "Vehiculos",
                column: "ModeloId",
                principalTable: "Modelos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Viaje_Vehiculos_VehiculoId",
                table: "Viaje",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Modelos_ModeloId",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Viaje_Vehiculos_VehiculoId",
                table: "Viaje");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehiculos",
                table: "Vehiculos");

            migrationBuilder.RenameTable(
                name: "Vehiculos",
                newName: "Vehiculo");

            migrationBuilder.RenameIndex(
                name: "IX_Vehiculos_ModeloId",
                table: "Vehiculo",
                newName: "IX_Vehiculo_ModeloId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehiculo",
                table: "Vehiculo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Modelos_ModeloId",
                table: "Vehiculo",
                column: "ModeloId",
                principalTable: "Modelos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Viaje_Vehiculo_VehiculoId",
                table: "Viaje",
                column: "VehiculoId",
                principalTable: "Vehiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
