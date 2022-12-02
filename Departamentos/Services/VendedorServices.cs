using Departamentos.Data;
using Departamentos.Models;

namespace Departamentos.Services
{
    public class VendedorServices 
    {
        private readonly DepartamentoContext _context;

        public VendedorServices(DepartamentoContext context)
        {
            _context = context;
        }

        public List<Vendedor> RetornaVendedor()
        {
            return _context.Vendedores.ToList();
            
           
        }

    }
}
