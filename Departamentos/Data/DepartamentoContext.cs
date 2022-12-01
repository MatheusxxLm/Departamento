using Departamentos.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Departamentos.Data
{
    public class DepartamentoContext : DbContext
    {

        public DepartamentoContext(DbContextOptions<DepartamentoContext> options)
            : base(options)
        {
        }

        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<RegistroDeVendas> Vendas { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
    }
}
