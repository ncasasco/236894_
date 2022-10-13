//using BusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CredentialsManager
    {
        private const int SaltSize = 16;
        private const int HashSize = 20;
        private readonly UserRepo usersRepo;
        public User UserLogged { get; set; }
        public CredentialsManager(UserRepo usersRepo, User admin)
        {
            this.usersRepo = usersRepo;
            SaveUser(admin);
        }

        public bool IsLogged { get; private set; }

        public void Login(Credentials userCredentials)
        {
            if (!usersRepo.Exists(userCredentials.Mail) && !usersRepo.Exists(userCredentials.Username))
                throw new BusinessLogicException("Invalid username or password");

            User storedUser = usersRepo.Get(userCredentials.Username);
            IsLogged = storedUser.Password == Hash(userCredentials.Password);
            UserLogged = IsLogged ? storedUser : throw new BusinessLogicException("Invalid username or password");
        }

        public void Register(User user)
        {
            if (!IsLogged)
                throw new BusinessLogicException("Not logged in");
            SaveUser(user);
        }

        public void Logout() => IsLogged = false;

        public void SaveUser(User user)
        {
            User newUser = user.DeepClone();
            newUser.Password = Hash(user.Password);
            usersRepo.Add(newUser);
        }

        private string Hash(string password, int iterations = 1000)
        {
            byte[] salt = new byte[SaltSize]; 
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            var hash = pbkdf2.GetBytes(HashSize);
            var hashedBase46String = Convert.ToBase64String(hash);

            return hashedBase46String;
        }
    }
}
