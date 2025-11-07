using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FASE_II_DAS_Gestion_de_expedientes_CRUD.Migrations
{
    /// <inheritdoc />
    public partial class CascadeDeleteAlumno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alumno",
                columns: table => new
                {
                    AlumnoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FechaNacimiento = table.Column<DateOnly>(type: "date", nullable: true),
                    Grado = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Alumno__90A6AA33D2C83993", x => x.AlumnoID);
                });

            migrationBuilder.CreateTable(
                name: "Materia",
                columns: table => new
                {
                    MaterialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMateria = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Docente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Materia__C50613179779BFA2", x => x.MaterialID);
                });

            migrationBuilder.CreateTable(
                name: "Expediente",
                columns: table => new
                {
                    ExpedienteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlumnoID = table.Column<int>(type: "int", nullable: true),
                    MaterialID = table.Column<int>(type: "int", nullable: true),
                    NotaFinal = table.Column<double>(type: "float", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Expedien__EBC60A569E6C1148", x => x.ExpedienteID);
                    table.ForeignKey(
                        name: "FK__Expedient__Alumn__3E52440B",
                        column: x => x.AlumnoID,
                        principalTable: "Alumno",
                        principalColumn: "AlumnoID");
                    table.ForeignKey(
                        name: "FK__Expedient__Mater__3F466844",
                        column: x => x.MaterialID,
                        principalTable: "Materia",
                        principalColumn: "MaterialID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expediente_AlumnoID",
                table: "Expediente",
                column: "AlumnoID");

            migrationBuilder.CreateIndex(
                name: "IX_Expediente_MaterialID",
                table: "Expediente",
                column: "MaterialID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expediente");

            migrationBuilder.DropTable(
                name: "Alumno");

            migrationBuilder.DropTable(
                name: "Materia");
        }
    }
}
