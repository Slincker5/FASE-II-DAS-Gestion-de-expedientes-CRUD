using System;
using System.Collections.Generic;

namespace FASE_II_DAS_Gestion_de_expedientes_CRUD.Models;

public partial class Materium
{
    public int MaterialId { get; set; }

    public string? NombreMateria { get; set; }

    public string? Docente { get; set; }

    public virtual ICollection<Expediente> Expedientes { get; set; } = new List<Expediente>();
}
