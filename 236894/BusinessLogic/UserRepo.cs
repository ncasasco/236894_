using BusinessLogic;
//using BusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogic
{
    public class UserRepo
    {

        IList<User> Users;

        public UserRepo()
        {
            Users = new List<User>();
        }

        public int Count { get => Users.Count; }

        public void Add(User user)
        {
            if (user is null)
                throw new ArgumentNullException(nameof(user));
            if (Exists(user.Mail))
                throw new BusinessLogicException("Mail already exists");
            if (Exists(user.Username))
                throw new BusinessLogicException("Username already exists");
            Users.Add(user);
        }

        public bool Exists(string text)
        {
            return Users.Any(user => user.Mail == text || user.Username == text);
        }

        public User Get(string text)
        {
            if (!Exists(text))
                throw new BusinessLogicException("User does not exist");
            return Users.First(user => user.Mail == text || user.Username == text);
        }

        public void Update(User user)
        {
            Remove(user.Mail);
            Add(user);
        }

        public void Remove(string mail)
        {
            Users = Users.Where(user => user.Mail != mail).ToList();
        }

        public IList<User> GetAll()
        {
            return new List<User>(Users);
        }

        public void Clear()
        {
            Users.Clear();
        }
    }
}
