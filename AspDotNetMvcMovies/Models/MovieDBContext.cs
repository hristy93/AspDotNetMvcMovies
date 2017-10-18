using System.Data.Entity;

namespace AspDotNetMvcMovies.Models
{
    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}