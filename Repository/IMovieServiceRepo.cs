using MovieApplication.Modals;

namespace MovieApplication.Repository
{
    public interface IMovieServiceRepo
    {
        Task<List<Movie>> GetMoviesList();
        Task AddNewMovie(Movie movie);
    }
}
