using Microsoft.AspNetCore.Mvc;

namespace FASE_II_DAS_Gestion_de_expedientes_CRUD.Controllers
{
    public class EditarEstudianteController : Controller
    {
        public IActionResult Editar(int id)
        {
            ViewBag.IdEstudiante = id;
            return View();
        }

    }
}
