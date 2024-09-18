using CMovie.Application;
using CMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMovie.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        //public static List<Movie> movies = new List<Movie>()
        //{
        //    new Movie { Id = 1, Name = "Passion of Christ", Cost = 3  },
        //    new Movie { Id = 2, Name = "iRobot", Cost = 1 }

        //};
        private readonly MovieDbContext _context;

        public MovieRepository(MovieDbContext context)
        {
            _context = context;
        }

        public Movie CreateMovie(Movie movie)
        {
           _context.Movies.Add(movie);
            _context.SaveChanges();

            return movie;
        }

        public void DeleteMovie(int id)
        {

            var movie = _context.Movies.FirstOrDefault(x=>x.MovieId == id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
                _context.SaveChanges();
            }
            return;
        }

        public List<Movie> GetAllMovies()
        {
           return _context.Movies.ToList();
            
        }

        public Movie UpdateMovie(Movie movie)
        {
            var movieUpdate = _context.Movies.Find(movie.MovieId);

            if (movieUpdate != null)
            {
                movieUpdate.MovieId = movie.MovieId;
                movieUpdate.RentalCost = movie.RentalCost;
                movieUpdate.MovieName = movie.MovieName;
                movieUpdate.RentalDuration = movie.RentalDuration;

                _context.SaveChanges();

            }

                return movie;


           

            }
        }
    }

