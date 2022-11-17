using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Genre
    {
        private string genreName;
        private string description { get; set; }

        [Key]
        public string GenreName
        {
            get => genreName;
            set
            {
                if (value?.Length == 0)
                    throw new BusinessLogicException($"Name cannot be empty");
                else
                    genreName = value;
            }
        }

        public string Description
        {
            get => description;
            set
            {
                if (value?.Length <= 0)
                    throw new ArgumentNullException("Description cannot be null");
                else
                    description = value;
            }
        }

        public bool Equals(Genre other) => other != null && other.GenreName.Equals(this.GenreName);

        public Genre DeepClone()
        {
            return new Genre()
            {
                genreName = this.GenreName,
                description = this.description,
            };
        }
    }
}
