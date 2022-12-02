using Microsoft.AspNetCore.Mvc;

namespace Departamentos.Controllers
{
    public class VendedorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
