using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Test
{
    [TestClass]
    public class CredentialsManagerTests
    {
        private User admin;
        private User simpleUser;
        private UserRepo usersRepo;

        private readonly DateTime May18th1998 = new DateTime(1998, 5, 18);

        [TestInitialize]
        public void Setup()
        {
            usersRepo = new UserRepo();
            admin = new User()
            {
                Mail = "adminnnnn",
                Username = "Johnnnnnnn",
                Password = "somepassword",
            };
            simpleUser = new User()
            {
                Mail = "userrrrr",
                Username = "Ryannnnnnn",
                Password = "anotherpassword",
            };
        }

        [TestMethod]
        public void ConstructorWithParametersTest()
        {
            var credentialsManager = new CredentialsManager(usersRepo, admin);
            Assert.IsNotNull(credentialsManager);
        }

        [TestMethod]
        public void LoginTest()
        {
            var credentialsManager = new CredentialsManager(usersRepo, admin);
            Credentials credentials = new Credentials()
            {
                Mail = admin.Mail,
                Username = admin.Username,
                Password = admin.Password
            };

            credentialsManager.Login(credentials);

            Assert.IsTrue(credentialsManager.IsLogged);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Invalid mail or password")]
        public void InvalidPasswordLoginTest()
        {
            var credentialsManager = new CredentialsManager(usersRepo, admin);
            Credentials credentials = new Credentials()
            {
                Mail = admin.Mail,
                Password = "invalid"
            };

            credentialsManager.Login(credentials);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Invalid mail or password")]
        public void InvalidMailLoginTest()
        {
            var credentialsManager = new CredentialsManager(usersRepo, admin);
            Credentials credentials = new Credentials()
            {
                Mail = "invalid",
                Password = admin.Password
            };

            credentialsManager.Login(credentials);
        }

        [TestMethod]
        public void HashedPasswordTest()
        {
            var credentialsManager = new CredentialsManager(usersRepo, admin);

            var storedUser = usersRepo.Get(admin.Mail);

            Assert.AreNotEqual(storedUser.Password, admin.Password);
        }

        [TestMethod]
        public void RegisterNewUserTest()
        {
            var credentialsManager = new CredentialsManager(usersRepo, admin);
            Credentials credentials = new Credentials()
            {
                Mail = admin.Mail,
                Username = admin.Username,
                Password = admin.Password
            };
            credentialsManager.Login(credentials);

            credentialsManager.Register(simpleUser);

            credentialsManager.Logout();
            Credentials newUserCredentials = new Credentials()
            {
                Mail = simpleUser.Mail,
                Username = simpleUser.Username,
                Password = simpleUser.Password
            };
            credentialsManager.Login(newUserCredentials);

            Assert.IsTrue(credentialsManager.IsLogged);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Insufficient permissions")]
        public void InsufficientPermissionsTest()
        {
            var credentialsManager = new CredentialsManager(usersRepo, admin);
            Credentials credentials = new Credentials()
            {
                Mail = admin.Mail,
                Password = admin.Password
            };
            credentialsManager.Login(credentials);
            credentialsManager.Register(simpleUser);
            credentialsManager.Logout();
            Credentials newUserCredentials = new Credentials()
            {
                Mail = simpleUser.Mail,
                Password = simpleUser.Password
            };
            credentialsManager.Login(newUserCredentials);
            credentialsManager.Register(simpleUser);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Not logged in")]
        public void NotLoggedInTest()
        {
            var credentialsManager = new CredentialsManager(usersRepo, admin);
            credentialsManager.Register(simpleUser);
        }

    }
}
