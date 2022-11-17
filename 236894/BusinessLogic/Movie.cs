using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Movie
    {
        private string movieName;
        private string genre;
        private string otherGenre;
        private string picturePath;
        public const int MaxPathLength = 260;
        private string description { get; set; }
        private bool isExplicit { get; set; }
        private bool isSponsored { get; set; }

        [Key]
        public string MovieName
        {
            get => movieName;
            set
            {
                if (value?.Length == 0)
                    throw new BusinessLogicException($"Name cannot be empty");
                else
                    movieName = value;
            }
        }

        public string Genre
        {
            get => genre;
            set
            {
                if (value?.Length <= 0)
                    throw new BusinessLogicException($"Genre cannot be empty");
                else
                    genre = value;
            }
        }

        public string OtherGenre
        {
            get => otherGenre;
            set
            {
               otherGenre = value;
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
        public string Description
        {
            get => description;
            set
            {
                if (value?.Length <= 0)
                    throw new BusinessLogicException("Description cannot be empty");
                else
                    description = value;
            }
        }

        public bool IsExplicit
        {
            get => isExplicit;

            set
            {
                isExplicit = value;
            }
        }

        public bool IsSponsored
        {
            get => isSponsored;

            set
            {
                isSponsored = value;
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
                isExplicit = this.isExplicit,
                isSponsored = this.isSponsored,
            };
        }
    }
}
