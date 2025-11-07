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
    }
}
