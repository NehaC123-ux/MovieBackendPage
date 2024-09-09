using Microsoft.EntityFrameworkCore;
using MovieApplication.DataMovie;
using MovieApplication.Modals;

namespace MovieApplication.Repository
{
    public class MovieServiceRepo:IMovieServiceRepo
    {
        private readonly MovieContext _context;
        public MovieServiceRepo(MovieContext movieContext)
        {
            this._context = movieContext;
            
        }

        public async Task AddNewMovie(Movie movie)
        {
            try
            {
                var result = await _context.Movies.AddAsync(movie);
                if(result == null)
                {
                    throw new Exception("It Will be Not Add");

                }
                await _context.SaveChangesAsync();
                
            }
            catch (Exception ex)
            {
                throw new Exception (ex.Message);
            }
            
        }

        public async Task<List<Movie>> GetMoviesList()
        {
            try
            {
                var result = await _context.Movies.ToListAsync();
                return result;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
