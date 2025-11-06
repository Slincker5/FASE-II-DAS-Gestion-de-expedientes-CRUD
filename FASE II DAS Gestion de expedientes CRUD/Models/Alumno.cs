using System;
using System.Collections.Generic;

namespace FASE_II_DAS_Gestion_de_expedientes_CRUD.Models;

public partial class Alumno
{
    public int AlumnoId { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public DateOnly? FechaNacimiento { get; set; }

    public string? Grado { get; set; }

    public virtual ICollection<Expediente> Expedientes { get; set; } = new List<Expediente>();
}
