using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MovieContext : DbContext
    {
        private Context dataContext;

        public MovieContext(Context dataContext)
        {
            this.dataContext = dataContext;
        }
        public int Count { get => this.dataContext.Movies.Count(); }

        public void AddMovie(Movie movie)
        {
            if (movie is null)
                throw new BusinessLogicException(nameof(movie));
            if (Exists(movie.MovieName))
                throw new BusinessLogicException("Movie already exists");
            this.dataContext.Movies.Add(movie);
            this.dataContext.SaveChanges();
        }

        public bool Exists(string moviename)
        {
            return this.dataContext.Movies.Any(movie => movie.MovieName == moviename);
        }

        public Movie Get(string moviename)
        {
            if (!Exists(moviename))
                throw new BusinessLogicException("Movie does not exist");
            return this.dataContext.Movies.First(movie => movie.MovieName == moviename);
        }

        public void Update(Movie movie)
        {
            Remove(movie.MovieName);
            this.dataContext.Movies.Add(movie);
            this.dataContext.SaveChanges();
        }

        public void Remove(string movieName)
        {
            var toRemove = this.dataContext.Movies.First(movie => movie.MovieName != movieName);
            this.dataContext.Movies.Remove(toRemove);
            this.dataContext.SaveChanges();
        }

        public List<Movie> getMovieList()
        {
            return this.dataContext.Movies.ToList();
        }
    }
}
