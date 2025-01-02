using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkTEst
{
    public class User
    {
        private string _login;
        private int _hashedPassword;

        public string Login 
        {  
            get => _login;
            private set => _login = value;
        }

        public string Password 
        {
            get => _hashedPassword.ToString();
            private set => _hashedPassword = value.GetHashCode();
        }

        public User(string login = "new user", string password = "password")
        {
            Login = login;
            Password = password;
        }
    }
}
