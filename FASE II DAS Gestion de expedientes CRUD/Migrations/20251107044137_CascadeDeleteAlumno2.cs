using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FASE_II_DAS_Gestion_de_expedientes_CRUD.Migrations
{
    /// <inheritdoc />
    public partial class CascadeDeleteAlumno2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Expedient__Alumn__3E52440B",
                table: "Expediente");

            migrationBuilder.AddForeignKey(
                name: "FK__Expedient__Alumn__3E52440B",
                table: "Expediente",
                column: "AlumnoID",
                principalTable: "Alumno",
                principalColumn: "AlumnoID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Expedient__Alumn__3E52440B",
                table: "Expediente");

            migrationBuilder.AddForeignKey(
                name: "FK__Expedient__Alumn__3E52440B",
                table: "Expediente",
                column: "AlumnoID",
                principalTable: "Alumno",
                principalColumn: "AlumnoID");
        }
    }
}
