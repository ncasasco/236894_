using System;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace BusinessLogic.Test
{
    [TestClass]
    public class CredentialsManagerTests
    {
        private User admin;
        private User simpleUser;
        private Context context;
        private UserContext userContext;

        private readonly DateTime May18th1998 = new DateTime(1998, 5, 18);

        [TestInitialize]
        public void Setup()
        {
            context = new Context();
            userContext = new UserContext(context);
            admin = new User()
            {
                Mail = "adminnnnnn",
                Username = "Johnnnnnnn",
                Password = "somepassword",
            };
            simpleUser = new User()
            {
                Mail = "userrrrrrr",
                Username = "Ryannnnnnn",
                Password = "anotherpassword",
            };
            userContext.AddUser(admin);
            userContext.AddUser(simpleUser);
        }

        [TestMethod]
        public void ConstructorWithParametersTest()
        {
            var credentialsManager = new CredentialsManager(userContext);
            Assert.IsNotNull(credentialsManager);
        }

        [TestMethod]
        public void LoginTest()
        {
            var credentialsManager = new CredentialsManager(userContext);
            Credentials credentials = new Credentials()
            {
                Mail = admin.Mail,
                Username = admin.Username,
                Password = admin.Password,
                isAdmin = admin.IsAdmin
            };

            credentialsManager.Login(credentials);

            Assert.IsTrue(credentialsManager.IsLogged);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Invalid mail or password")]
        public void InvalidPasswordLoginTest()
        {
            var credentialsManager = new CredentialsManager(userContext);
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
            var credentialsManager = new CredentialsManager(userContext);
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
            var credentialsManager = new CredentialsManager(userContext);

            var storedUser = userContext.Get(admin.Mail);

            Assert.AreNotEqual(storedUser.Password, admin.Password);
        }

        [TestMethod]
        public void RegisterNewUserTest()
        {
            var credentialsManager = new CredentialsManager(userContext);
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
            var credentialsManager = new CredentialsManager(userContext);
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
            var credentialsManager = new CredentialsManager(userContext);
            credentialsManager.Register(simpleUser);
        }

        [TestCleanup]
        public void CleanUp()
        {
            foreach (var user in this.context.Users.ToList())
            {
                this.context.Users.Remove(user);
            }
            this.context.SaveChanges();
        }

    }
}
