using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Movie
    {
        private string movieName;
        private IList<Genre> genre;
        private string picturePath;
        public const int MaxPathLength = 260;
        private string description { get; set; }
        private bool isApt { get; set; }
        private bool isSponsored { get; set; }

        public string MovieName
        {
            get => movieName;
            set
            {
                if (value?.Length == 0)
                    throw new BusinessLogicException($"Name can't be empty");
                else
                    movieName = value;
            }
        }

        public string PicturePath
        {
            get => picturePath;
            set
            {
                if (value?.Length <= 0)
                    throw new BusinessLogicException("Please pick a poster");
                if (value?.Length > MaxPathLength)
                    throw new BusinessLogicException($"Poster path is too long. Maximum length is {MaxPathLength}");
                picturePath = value;
            }
        }

        public bool Equals(User other) => other != null && other.Mail.Equals(this.MovieName);

        public Movie DeepClone()
        {
            return new Movie()
            {
                movieName = this.MovieName,
                picturePath = this.PicturePath,
                description = this.description,
                isApt = this.isApt,
                isSponsored = this.isSponsored,
            };
        }
    }
}
