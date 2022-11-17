using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class GenreContext : DbContext
    {
        private Context dataContext;

        public GenreContext(Context dataContext)
        {
            this.dataContext = dataContext;
        }
        public int Count { get => this.dataContext.Genres.Count(); }

        public void AddGenre(Genre genre)
        {
            if (genre is null)
                throw new BusinessLogicException(nameof(genre));
            if (Exists(genre.GenreName))
                throw new BusinessLogicException("Genre already exsists");
            this.dataContext.Genres.Add(genre);
            this.dataContext.SaveChanges();
        }

        public bool Exists(string genrename)
        {
            return this.dataContext.Genres.Any(genre => genre.GenreName == genrename);
        }

        public Genre Get(string genrename)
        {
            if (!Exists(genrename))
                throw new BusinessLogicException("Genre does not exist");
            return this.dataContext.Genres.First(genre => genre.GenreName == genrename);
        }

        public void Update(Genre genre)
        {
            Remove(genre.GenreName);
            this.dataContext.Genres.Add(genre);
            this.dataContext.SaveChanges();
        }

        public void Remove(string genrename)
        {
            var toRemove = this.dataContext.Genres.First(genre => genre.GenreName != genrename);
            this.dataContext.Genres.Remove(toRemove);
            this.dataContext.SaveChanges();
        }

        public List<Genre> getGenreList()
        {
            return this.dataContext.Genres.ToList();
        }
    }
}
