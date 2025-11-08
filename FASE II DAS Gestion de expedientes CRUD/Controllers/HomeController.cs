using System.Diagnostics;
using FASE_II_DAS_Gestion_de_expedientes_CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FASE_II_DAS_Gestion_de_expedientes_CRUD.Controllers
{
    public class HomeController : Controller
    {
        private readonly GestionexpedienteContext _context;

        public  HomeController(GestionexpedienteContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Alumno> alumno = _context.Alumnos.ToList();
            return View(alumno);
        }
    }
}
