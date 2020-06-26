using Microsoft.EntityFrameworkCore.Migrations;

namespace FAS.Repository.Migrations
{
    public partial class correcc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conductores_Trbajadores_TrabajadorId",
                table: "Conductores");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleViajes_Viaje_ViajeId",
                table: "DetalleViajes");

            migrationBuilder.DropForeignKey(
                name: "FK_Trbajadores_Usuarios_UsuarioId",
                table: "Trbajadores");

            migrationBuilder.DropForeignKey(
                name: "FK_Viaje_Conductores_ConductorId",
                table: "Viaje");

            migrationBuilder.DropForeignKey(
                name: "FK_Viaje_Vehiculos_VehiculoId",
                table: "Viaje");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Viaje",
                table: "Viaje");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trbajadores",
                table: "Trbajadores");

            migrationBuilder.RenameTable(
                name: "Viaje",
                newName: "Viajes");

            migrationBuilder.RenameTable(
                name: "Trbajadores",
                newName: "Trabajadores");

            migrationBuilder.RenameIndex(
                name: "IX_Viaje_VehiculoId",
                table: "Viajes",
                newName: "IX_Viajes_VehiculoId");

            migrationBuilder.RenameIndex(
                name: "IX_Viaje_ConductorId",
                table: "Viajes",
                newName: "IX_Viajes_ConductorId");

            migrationBuilder.RenameIndex(
                name: "IX_Trbajadores_UsuarioId",
                table: "Trabajadores",
                newName: "IX_Trabajadores_UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Viajes",
                table: "Viajes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trabajadores",
                table: "Trabajadores",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Conductores_Trabajadores_TrabajadorId",
                table: "Conductores",
                column: "TrabajadorId",
                principalTable: "Trabajadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleViajes_Viajes_ViajeId",
                table: "DetalleViajes",
                column: "ViajeId",
                principalTable: "Viajes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trabajadores_Usuarios_UsuarioId",
                table: "Trabajadores",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Viajes_Conductores_ConductorId",
                table: "Viajes",
                column: "ConductorId",
                principalTable: "Conductores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Viajes_Vehiculos_VehiculoId",
                table: "Viajes",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conductores_Trabajadores_TrabajadorId",
                table: "Conductores");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleViajes_Viajes_ViajeId",
                table: "DetalleViajes");

            migrationBuilder.DropForeignKey(
                name: "FK_Trabajadores_Usuarios_UsuarioId",
                table: "Trabajadores");

            migrationBuilder.DropForeignKey(
                name: "FK_Viajes_Conductores_ConductorId",
                table: "Viajes");

            migrationBuilder.DropForeignKey(
                name: "FK_Viajes_Vehiculos_VehiculoId",
                table: "Viajes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Viajes",
                table: "Viajes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trabajadores",
                table: "Trabajadores");

            migrationBuilder.RenameTable(
                name: "Viajes",
                newName: "Viaje");

            migrationBuilder.RenameTable(
                name: "Trabajadores",
                newName: "Trbajadores");

            migrationBuilder.RenameIndex(
                name: "IX_Viajes_VehiculoId",
                table: "Viaje",
                newName: "IX_Viaje_VehiculoId");

            migrationBuilder.RenameIndex(
                name: "IX_Viajes_ConductorId",
                table: "Viaje",
                newName: "IX_Viaje_ConductorId");

            migrationBuilder.RenameIndex(
                name: "IX_Trabajadores_UsuarioId",
                table: "Trbajadores",
                newName: "IX_Trbajadores_UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Viaje",
                table: "Viaje",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trbajadores",
                table: "Trbajadores",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Conductores_Trbajadores_TrabajadorId",
                table: "Conductores",
                column: "TrabajadorId",
                principalTable: "Trbajadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleViajes_Viaje_ViajeId",
                table: "DetalleViajes",
                column: "ViajeId",
                principalTable: "Viaje",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trbajadores_Usuarios_UsuarioId",
                table: "Trbajadores",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Viaje_Conductores_ConductorId",
                table: "Viaje",
                column: "ConductorId",
                principalTable: "Conductores",
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
    }
}
