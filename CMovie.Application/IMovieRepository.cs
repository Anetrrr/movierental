using CMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMovie.Application
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();

        Movie CreateMovie(Movie movie);

        Movie UpdateMovie(Movie movie);

        void DeleteMovie(int id);



    }
}
