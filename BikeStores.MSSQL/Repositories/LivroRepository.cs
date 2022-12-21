using BikeStores.MSSQL.Data;
using BikeStores.MSSQL.Models;

namespace BikeStores.MSSQL.Repositories
{
    public class LivroRepository
    {
        private readonly BikestoresContext _context;

        public LivroRepository(BikestoresContext context)
        {
            _context = context;
        }

        public List<Livro> Listar()
        {
            // SELECT Id, Titulo, QuantidadePaginas, Disponivel FROM Livros;
            return _context.Livros.ToList();
        }

        public void Cadastrar(Livro livro)
        {
            _context.Livros.Add(livro);
             
            _context.SaveChanges();
        }
    }
}
