using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BusinessLogic.Test
{
    [TestClass]
    public class GenreTest
    {
        private Genre aGenre;
        private const string John = "Johnnnnnnn";
        private const string johndoe25 = "johndoeeee";
        private const string tooShortPassword = "Matias1";
        private const string TooLongName = "ExtremelyLongLongLongNameAndAlsoExtremelyLongLongLongLastName";

        [TestInitialize]
        public void Initialize()
        {
            aGenre = new Genre()
            {
                GenreName = John,
                Description = TooLongName,
            };
        }

        [TestMethod]
        public void ConstructorTest()
        {
            Genre Genre = new Genre();
            Assert.IsNotNull(Genre);
        }

        [TestMethod]
        public void DescNotNullTest()
        {
            aGenre.Description = null;
        }

        [TestMethod]
        public void setGenreNameTest()
        {
            aGenre.GenreName = johndoe25;
            Assert.AreEqual(johndoe25, aGenre.GenreName);
        }

        [TestMethod]
        public void GenreNameNotNullTest()
        {
            aGenre.GenreName = null;
        }

        [TestMethod]
        public void setDescTest()
        {
            aGenre.Description = johndoe25;
            Assert.AreEqual(johndoe25, aGenre.Description);
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
