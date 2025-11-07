using System.Diagnostics;
using FASE_II_DAS_Gestion_de_expedientes_CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FASE_II_DAS_Gestion_de_expedientes_CRUD.Controllers
{
    public class EditarEstudianteController : Controller
    {
        private readonly GestionexpedienteContext _context;

        public EditarEstudianteController(GestionexpedienteContext context)
        {
            _context = context;
        }
        public IActionResult Editar(int id)
        {
            Alumno? informacionEstudiante = _context.Alumnos.Find(id);
            return View(informacionEstudiante);
        }

        public IActionResult Eliminar(int id)
        {
            Alumno? alumno = _context.Alumnos.Find(id);
            _context.Alumnos.Remove(alumno);
            _context.SaveChanges();

            return Ok(new { mensaje = "Eliminado correctamente" });
        }
    }
}
