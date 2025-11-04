namespace FASE_II_DAS_Gestion_de_expedientes_CRUD.Models
{
    public class Alumno
    {
        int AlumnoId { get; set; }
        string Nombre  { get; set; }
        string Apellido { get; set; }
        DateTime FechaNacimiento { get; set; }
        int Grado { get; set; }

        public Alumno(int alumnoId, string nombre, string apellido, DateTime fechaNacimiento, int grado)
        {
            AlumnoId = alumnoId;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Grado = grado;
        }
    }
}
