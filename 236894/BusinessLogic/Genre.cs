using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Genre
    {
        private string genreName;
        private string description { get; set; }
        
        public string GenreName
        {
            get => genreName;
            set
            {
                if (value?.Length == 0)
                    throw new BusinessLogicException($"Name can't be empty");
                else
                    genreName = value;
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
