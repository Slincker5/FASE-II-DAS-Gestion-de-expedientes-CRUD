namespace FASE_II_DAS_Gestion_de_expedientes_CRUD.Models
{
    public class Materia
    {
        int MateriaId { get; set; }
        string NombreMateria { get; set; }
        string Docente { get; set; }
        public Materia(int materiaId, string nombremateria, string docente)
        {
            MateriaId = materiaId;
            NombreMateria = nombremateria;
            Docente = docente;
        }
    }
}
