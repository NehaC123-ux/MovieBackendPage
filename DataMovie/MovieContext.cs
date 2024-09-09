using Microsoft.EntityFrameworkCore;
using MovieApplication.Modals;

namespace MovieApplication.DataMovie
{
    public class MovieContext:DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options):base(options)
        {
            
        }
        public DbSet<Movie> Movies { get; set; }
    }
}
