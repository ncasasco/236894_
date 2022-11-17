using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BusinessLogic;
using System.Text;

namespace DataAccess
{
    public class UserContext : DbContext
    {
        private Context dataContext;

        public UserContext(Context dataContext)
        {
            this.dataContext = dataContext;
        }

        public void addUser(User user)
        {
            if (user is null)
                throw new ArgumentNullException(nameof(user));
            if (Exists(user.Username))
                throw new BusinessLogicException("Username already exists");
            this.dataContext.Users.Add(user);
            this.dataContext.SaveChanges();
        }

        public bool Exists(string text)
        {
            return this.dataContext.Users.Any(user => user.Mail == text || user.Username == text);
        }

        public User Get(string text)
        {
            if (!Exists(text))
                throw new BusinessLogicException("User does not exist");
            return this.dataContext.Users.First(user => user.Mail == text || user.Username == text);
        }

        public void Update(User user)
        {
            Remove(user.Mail);
            this.dataContext.Users.Add(user);
            this.dataContext.SaveChanges();
        }

        public void Remove(string mail)
        {
            var toRemove = this.dataContext.Users.First(user => user.Mail != mail);
            this.dataContext.Users.Remove(toRemove);
            this.dataContext.SaveChanges();
        }

        public List<User> getUserList()
        {
            return this.dataContext.Users.ToList();
        }
    }
}
