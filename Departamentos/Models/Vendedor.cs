namespace Departamentos.Models
{
    public class Vendedor
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public double SalarioBase { get; set; }
        public Departamento departamento { get; set; }
        public ICollection<RegistroDeVendas> Vendas { get; set; } = new List<RegistroDeVendas>();
        
        public Vendedor()
        {

        }

        public Vendedor(int id, string nome, string email, DateTime dataNascimento, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            SalarioBase = salarioBase;
            this.departamento = departamento;
        }

        public void AddVenda(RegistroDeVendas registro)
        {
            Vendas.Add(registro);
        }
        public void RemoverVenda(RegistroDeVendas registro)
        {
            Vendas.Remove(registro);
        }
        public double TotalDeVendas(DateTime Inicio, DateTime Final)
        {
            return Vendas.Where(x => x.Data >= Inicio && x.Data <= Final).Sum(x => x.Quantidade);
        }

    }
}


