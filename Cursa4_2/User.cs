using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursa4_2
{
    public class User
    {
        static public List<User> Users = new List<User>();
        public string Login;
        public string Password;

        public User(string login, string password)
        {
            Login = login;
            Password = password;
            User.Users.Add(this);
        }
    }
}
