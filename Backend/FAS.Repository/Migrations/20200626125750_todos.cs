using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FAS.Repository.Migrations
{
    public partial class todos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdVehiculo",
                table: "Viaje",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VehiculoId",
                table: "Viaje",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Modelo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    modelo = table.Column<string>(nullable: true),
                    cargamax = table.Column<string>(nullable: true),
                    nrollantas = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    placa = table.Column<string>(nullable: true),
                    nromotor = table.Column<string>(nullable: true),
                    estadomotor = table.Column<bool>(nullable: false),
                    IdModelo = table.Column<int>(nullable: false),
                    ModeloId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Modelo_ModeloId",
                        column: x => x.ModeloId,
                        principalTable: "Modelo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Viaje_VehiculoId",
                table: "Viaje",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_ModeloId",
                table: "Vehiculo",
                column: "ModeloId");

            migrationBuilder.AddForeignKey(
                name: "FK_Viaje_Vehiculo_VehiculoId",
                table: "Viaje",
                column: "VehiculoId",
                principalTable: "Vehiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Viaje_Vehiculo_VehiculoId",
                table: "Viaje");

            migrationBuilder.DropTable(
                name: "Vehiculo");

            migrationBuilder.DropTable(
                name: "Modelo");

            migrationBuilder.DropIndex(
                name: "IX_Viaje_VehiculoId",
                table: "Viaje");

            migrationBuilder.DropColumn(
                name: "IdVehiculo",
                table: "Viaje");

            migrationBuilder.DropColumn(
                name: "VehiculoId",
                table: "Viaje");
        }
    }
}
