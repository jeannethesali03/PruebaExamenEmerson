using Microsoft.EntityFrameworkCore;

namespace pruebaBorrar.Modelos
{
    public class BibliotecaContext:DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options)
        {

        }

        public DbSet<Autor> Autor { get; set; }
        public DbSet<Libro> Libro { get; set; }
    }
}
