using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCVeterinaria.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Turno",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "date", nullable: false),
                    Hora = table.Column<TimeSpan>(type: "time", nullable: false),
                    NombreMascota = table.Column<string>(maxLength: 50, nullable: false),
                    TipoMascota = table.Column<int>(nullable: false),
                    Raza = table.Column<string>(maxLength: 50, nullable: true),
                    Edad = table.Column<int>(nullable: false),
                    NombreDuenio = table.Column<string>(maxLength: 50, nullable: false),
                    Celular = table.Column<string>(maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turno", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Turno");
        }
    }
}
