namespace BikeStores.MSSQL.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = String.Empty;
        public int QuantidadePaginas { get; set; }
        public bool Disponivel { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
