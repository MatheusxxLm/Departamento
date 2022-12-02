using Departamentos.Services;
using Microsoft.AspNetCore.Mvc;

namespace Departamentos.Controllers
{
    public class VendedorController : Controller
    {
        private readonly VendedorServices _VendedorServices;
        public VendedorController(VendedorServices vendedorServices)
        {
            _VendedorServices = vendedorServices;
        }

        public IActionResult Index()
        {
            var list = _VendedorServices.RetornaVendedor();

            return View(list);
        }
    }
}
