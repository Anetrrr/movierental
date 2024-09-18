using CMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMovie.Application
{
    public class MovieService : IMovieService

    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public Movie CreateMovie(Movie movie)
        {
          var newMovie = _movieRepository.CreateMovie(movie);

            return newMovie;
        }

        public void DeleteMovie(int id)
        {
            _movieRepository.DeleteMovie(id);
            return;
        }

        public List<Movie> GetAllMovies()
        {
            var movies = _movieRepository.GetAllMovies();

            return movies;
        }

        public Movie UpdateMovie(Movie movie)
        {
            var movieUpdate = _movieRepository.UpdateMovie(movie);  

            return movieUpdate;
        }
    }
}
