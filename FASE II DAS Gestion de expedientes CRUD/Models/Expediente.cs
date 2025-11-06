using System;
using System.Collections.Generic;

namespace FASE_II_DAS_Gestion_de_expedientes_CRUD.Models;

public partial class Expediente
{
    public int ExpedienteId { get; set; }

    public int? AlumnoId { get; set; }

    public int? MaterialId { get; set; }

    public double? NotaFinal { get; set; }

    public string? Observaciones { get; set; }

    public virtual Alumno? Alumno { get; set; }

    public virtual Materium? Material { get; set; }
}
