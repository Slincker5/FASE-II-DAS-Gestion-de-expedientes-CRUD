using FASE_II_DAS_Gestion_de_expedientes_CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FASE_II_DAS_Gestion_de_expedientes_CRUD.Controllers
{
    public class ExpedienteController : Controller
    {
        private readonly GestionexpedienteContext _context;

        public ExpedienteController(GestionexpedienteContext context)
        {
            _context = context;
        }
        public IActionResult Ver(int id)
        {
            var alumno = _context.Alumnos
                .Include(a => a.Expedientes)
                    .ThenInclude(e => e.Material)
                .FirstOrDefault(a => a.AlumnoId == id);

            if (alumno == null)
                return NotFound();

            return View(alumno);
        }


        [HttpGet]
        public IActionResult Editar(int id)
        {
            var expediente = _context.Expedientes
                .Include(e => e.Alumno)
                .FirstOrDefault(e => e.ExpedienteId == id);

            if (expediente == null)
                return NotFound();

            return View(expediente);
        }

        [HttpPost]
        public IActionResult Editar(Expediente expediente)
        {
            var existente = _context.Expedientes.Find(expediente.ExpedienteId);
            if (existente == null)
                return NotFound();

            existente.NotaFinal = expediente.NotaFinal;
            existente.Observaciones = expediente.Observaciones;
            _context.SaveChanges();

            return RedirectToAction("Ver", new { id = expediente.AlumnoId });
        }

        [HttpGet]
        public IActionResult Eliminar(int id)
        {
            var expediente = _context.Expedientes
                .Include(e => e.Alumno)
                .Include(e => e.Material)
                .FirstOrDefault(e => e.ExpedienteId == id);

            if (expediente == null)
                return NotFound();

            return View(expediente);
        }

        [HttpPost]
        public IActionResult Eliminar(int expedienteId, int alumnoId)
        {
            var expediente = _context.Expedientes.Find(expedienteId);
            if (expediente == null)
                return NotFound();

            _context.Expedientes.Remove(expediente);
            _context.SaveChanges();

            return RedirectToAction("Ver", new { id = alumnoId });
        }

    }
}
