using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApplication.Modals;
using MovieApplication.Repository;

namespace MovieApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieServiceRepo _repository;
        public MovieController(IMovieServiceRepo movieService)
        {
            this._repository = movieService;
        }
        [HttpGet("GetNewMoviesList")]
        public async Task<IActionResult>GetNewMoviesList()
        {
            try
            {
                var result=await _repository.GetMoviesList();
                return Ok(result);
            }
            catch (Exception ex)
            {
               return BadRequest(ex.Message);
            }
        }
        [HttpPost("AddNewMovieData")]
        public async Task<IActionResult> AddNewMovieData(Movie movie)
        {
            try
            {
                await _repository.AddNewMovie(movie);
                return Ok("Added Movie SuccessFully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
