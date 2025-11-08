using Microsoft.AspNetCore.Mvc;
using FASE_II_DAS_Gestion_de_expedientes_CRUD.Models;
using System.Linq;

namespace FASE_II_DAS_Gestion_de_expedientes_CRUD.Controllers
{
    public class MateriaController : Controller
    {
        private readonly GestionexpedienteContext _context;

        public MateriaController(GestionexpedienteContext context)
        {
            _context = context;
        }

        public IActionResult Ver()
        {
            var materias = _context.Materia.ToList();
            return View(materias);
        }

        // agregar materia
        [HttpGet]
        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(Materium materia)
        {
            if (!ModelState.IsValid)
                return View(materia);

            _context.Materia.Add(materia);
            _context.SaveChanges();

            return RedirectToAction("Ver");
        }

        // editar materia
        [HttpGet]
        public IActionResult Editar(int id)
        {
            var materia = _context.Materia.Find(id);
            if (materia == null)
                return NotFound();

            return View(materia);
        }

        [HttpPost]
        public IActionResult Editar(Materium materia)
        {
            if (!ModelState.IsValid)
                return View(materia);

            _context.Materia.Update(materia);
            _context.SaveChanges();

            return RedirectToAction("Ver");
        }

        // action eliminar materia
        [HttpGet]
        public IActionResult Eliminar(int id)
        {
            var materia = _context.Materia.Find(id);
            if (materia == null)
                return NotFound();

            return View(materia);
        }

        [HttpPost]
        public IActionResult Eliminar(Materium materia)
        {
            var eliminar = _context.Materia.Find(materia.MaterialId);
            if (eliminar == null)
                return NotFound();

            _context.Materia.Remove(eliminar);
            _context.SaveChanges();

            return RedirectToAction("Ver");
        }

    }
}
