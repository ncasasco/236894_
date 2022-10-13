using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class MovieRepo
    {
        IList<Movie> Movies;

        public MovieRepo()
        {
            Movies = new List<Movie>();
        }

        public int Count { get => Movies.Count; }

        public void Add(Movie movie)
        {
            if (movie is null)
                throw new BusinessLogicException(nameof(movie));
            if (Exists(movie.MovieName))
                throw new BusinessLogicException("Movie already exsists");

            Movies.Add(movie);
        }

        public bool Exists(string moviename)
        {
            return Movies.Any(movie => movie.MovieName == moviename);
        }

        public Movie Get(string moviename)
        {
            if (!Exists(moviename))
                throw new BusinessLogicException("Movie does not exist");
            return Movies.First(movie => movie.MovieName == moviename);
        }

        public void Update(Movie movie)
        {
            Remove(movie.MovieName);
            Add(movie);
        }

        public void Remove(string moviename)
        {
            Movies = Movies.Where(movie => movie.MovieName != moviename).ToList();
        }

        public IList<Movie> GetAll()
        {
            return new List<Movie>(Movies);
        }

        public void Clear()
        {
            Movies.Clear();
        }
    }
}
