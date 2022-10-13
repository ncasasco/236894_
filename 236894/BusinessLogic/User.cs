//using BusinessLogic.Exceptions;
using System;

namespace BusinessLogic
{
    public class User
    {
        private string mail;
        private string username;
        private string password;
        private bool isAdmin;
        public const int MailMinLength = 4;
        public const int MailMaxLength = 30;
        public const int UsernameMinLength = 10;
        public const int UsernameMaxLength = 20;
        public const int PasswordMinLength = 10;
        public const int PasswordMaxLength = 30;

        public string Mail
        {
            get => mail;
            set
            {
                if (value?.Length < MailMinLength || value?.Length > MailMaxLength)
                    throw new BusinessLogicException($"Mail length must be between {MailMinLength} and {MailMaxLength} characters");
                else 
                    mail = value;
            }
        }
        public string Username
        {
            get => username;
            set
            {
                if (value?.Length < UsernameMinLength || value?.Length > UsernameMaxLength)
                    throw new BusinessLogicException($"Username length must be between {UsernameMinLength} and {UsernameMaxLength} characters");
                else
                    username = value;
            }
        }
        public string Password
        {
            get => password;
            set
            {
                if (value?.Length < PasswordMinLength || value?.Length > PasswordMaxLength)
                    throw new BusinessLogicException($"Password length must be between {PasswordMinLength} and {PasswordMaxLength} characters");
                else
                    password = value;
            }
        }
        public bool IsAdmin { get; set; }
        public bool Equals(User other) => other != null && other.Mail.Equals(this.Mail);

        public User DeepClone()
        {
            return new User()
            {
                mail = this.Mail,
                password = this.Password,
                username = this.Username,
                isAdmin = this.IsAdmin
            };
        }

    }
}