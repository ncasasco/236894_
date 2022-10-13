using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class GenreRepo
    {
        IList<Genre> Genres;

        public GenreRepo()
        {
            Genres = new List<Genre>();
        }

        public int Count { get => Genres.Count; }

        public void Add(Genre genre)
        {
            if (genre is null)
                throw new BusinessLogicException(nameof(genre));
            if (Exists(genre.GenreName))
                throw new BusinessLogicException("genre already exsists");

            Genres.Add(genre);
        }

        public bool Exists(string genrename)
        {
            return Genres.Any(genre => genre.GenreName == genrename);
        }

        public Genre Get(string genrename)
        {
            if (!Exists(genrename))
                throw new BusinessLogicException("Genre does not exist");
            return Genres.First(genre => genre.GenreName == genrename);
        }

        public void Update(Genre genre)
        {
            Remove(genre.GenreName);
            Add(genre);
        }

        public void Remove(string genrename)
        {
            Genres = Genres.Where(genre => genre.GenreName != genrename).ToList();
        }

        public IList<Genre> GetAll()
        {
            return new List<Genre>(Genres);
        }

        public void Clear()
        {
            Genres.Clear();
        }
    }
}
