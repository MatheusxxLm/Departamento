using System.ComponentModel.DataAnnotations;

namespace Departamentos.Models
{
    public class Departamento
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<Vendedor> Vendedor { get; set; } = new List<Vendedor>();

        public Departamento()
        {

        }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AddVendedor(Vendedor vendedor)
        {
            Vendedor.Add(vendedor);
        }
        public double TotalDeVendas(DateTime Inicio, DateTime Final)
        {
            return Vendedor.Sum(vendedor => vendedor.TotalDeVendas(Inicio, Final));
        }
    }
}
