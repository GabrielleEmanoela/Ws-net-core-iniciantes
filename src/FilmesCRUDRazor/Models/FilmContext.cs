using Microsoft.EntityFrameworkCore;

namespace FilmesCRUDRazor.Models
{


    public class FilmContext : DbContext
    {
        public FilmContext(DbContextOptions<FilmContext> options)
        : base(options)
        {
        }
        public DbSet<Film> Film { get; set; }

    }
}
