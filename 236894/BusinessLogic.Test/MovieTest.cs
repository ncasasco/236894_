using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BusinessLogic.Test
{
    [TestClass]
    public class MovieTest
    {
        private Movie aMovie;
        private const string John = "Johnnnnnnn";
        private const string johndoe25 = "johndoeeee";
        private const string tooShortPassword = "Matias1";
        private const string TooLongName = "ExtremelyLongLongLongNameAndAlsoExtremelyLongLongLongLastName";

        [TestInitialize]
        public void Initialize()
        {
            aMovie = new Movie()
            {
                MovieName = John,
                Genre = johndoe25,
                OtherGenre = johndoe25,
                PicturePath = TooLongName,
                Description = johndoe25,

            };
        }

        [TestMethod]
        public void ConstructorTest()
        {
            Movie Movie = new Movie();
            Assert.IsNotNull(Movie);
        }

        [TestMethod]
        public void setMovieNameTest()
        {
            aMovie.MovieName = johndoe25;
            Assert.AreEqual(johndoe25, aMovie.MovieName);
        }

        [TestMethod]
        public void MovieNameNotNullTest()
        {
            aMovie.MovieName = null;
        }

        private static string GenerateString(string text, int length)
        {
            string tooLongPath = "";
            while (tooLongPath.Length < length)
                tooLongPath += text;
            return tooLongPath;
        }
    }
}
