namespace FASE_II_DAS_Gestion_de_expedientes_CRUD.Models
{
    public class Expediente
    {
        int ExpedienteId { get; set; }
        int AlumnoId { get; set; }
        int MateriaId { get; set; }
        int NotaFinal { get; set; }
        string Observaciones { get; set; }
        public Expediente(int expedienteId, int alumnoId, int materiaId, int notaFinal, string observaciones)
        {
            ExpedienteId = expedienteId;
            AlumnoId = alumnoId;
            MateriaId = materiaId;
            NotaFinal = notaFinal;
            Observaciones = observaciones;
        }


    }
}
