﻿
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BusinessLogic.Test
{
    [TestClass]
    public class UserTest
    {
        private User johnDoeUser;
        private const string John = "Johnnnnnn";
        private const string johndoe25 = "johndoeeee";
        private const string tooShortPassword = "Matias1";
        private const string TooLongName = "ExtremelyLongLongLongNameAndAlsoExtremelyLongLongLongLastName";

        [TestInitialize]
        public void Initialize()
        {
            johnDoeUser = new User()
            {
                Username = John,
                Mail = johndoe25,
            };
        }

        [TestMethod]
        public void ConstructorTest()
        {
            User User = new User();

            Assert.IsNotNull(User);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Mail length must be between 8 and 30")]
        public void MailMaxLengthTest()
        {
            johnDoeUser.Mail = TooLongName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Mail length must be between 8 and 30")]
        public void MailMinLengthTest()
        {
            johnDoeUser.Mail = "";
        }

        [TestMethod]
        public void MailNotNullTest()
        {
            johnDoeUser.Mail = null;
        }

        [TestMethod]
        public void setMailTest()
        {
            johnDoeUser.Mail = johndoe25;
            Assert.AreEqual(johndoe25, johnDoeUser.Mail);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Username length must be between 10 and 30")]
        public void UsernameMaxLengthTest()
        {
            johnDoeUser.Username = TooLongName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Username length must be between 10 and 30")]
        public void UsernameMinLengthTest()
        {
            johnDoeUser.Username = "";
        }

        [TestMethod]
        public void setUsernameTest()
        {
            johnDoeUser.Username = John;
            Assert.AreEqual(John, johnDoeUser.Username);
        }

        [TestMethod]
        public void UsernameNotNullTest()
        {
            johnDoeUser.Username = null;
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
