using CMovie.Application;
using CMovie.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CMovie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    // this is the presentationlayer: depends on the application layer. instead of injecting the repository, it injects the service present in the 
    //application layer
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
            
        }
        // GET: api/<MoviesController>
        [HttpGet]
        public ActionResult<List<Movie>> GetAll()
        {
            var moviesFromService = _movieService.GetAllMovies();

            return Ok(moviesFromService);
        
        }

        [HttpPost]
        public ActionResult<Movie> PostMovie(Movie movie)
        {
            var movieNew = _movieService.CreateMovie(movie);
            return Ok(movieNew);

        }

        [HttpPut]
        public ActionResult<Movie> UpdateMovie(Movie movie)
        {
            var movieNew = _movieService.UpdateMovie(movie);

            return Ok(movieNew);

        }

        [HttpDelete]
        public IActionResult DeleteMovie(int id)
        {
          _movieService.DeleteMovie(id);

            return Ok();

        }

    }
}
