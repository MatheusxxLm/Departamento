using Departamentos.Models.Enums;

namespace Departamentos.Models
{
    public class RegistroDeVendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Quantidade { get; set; }
        public StatusDeVenda Status { get; set; }
        public Vendedor vendedor { get; set; }

        public RegistroDeVendas()
        {

        }

        public RegistroDeVendas(int id, DateTime data, double quantidade, StatusDeVenda status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Quantidade = quantidade;
            Status = status;
            this.vendedor = vendedor;
        }
    }
}
