using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkTEst
{
    public class VirtualStore
    {
        private List<User> _users = new List<User>();

        public VirtualStore() 
        {
           _users.Add(new User("root", "root"));
            _users.Add(new User("guest", "guest"));
        }

        public User RegisterUser(User user)
        {
            foreach (User u in _users)
            {
                if(u.Login == user.Login)
                {
                    Console.WriteLine("user already exists");
                    return null;
                }
            }
            _users.Add(user);
            return user;
        }

        public void RemoveUser(User user) 
        {
            foreach (User u in _users)
            {
                if (u.Login == user.Login &&  u.Password == user.Password)
                {
                    _users.Remove(u);
                    Console.WriteLine("user removed");
                }
            }
        }

        public User FindUser(User user) 
        {
            foreach (User u in _users)
            {
                if (u.Login == user.Login)
                {
                    Console.WriteLine($"find user by login {u.Login}");
                    return u;
                }
            }
            return null;
        }
    }
}
