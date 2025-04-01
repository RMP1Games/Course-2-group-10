using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _180325_.Models;
using _180325_.Services.Interfaces;

namespace _180325_.Controllers
{
    internal class CUser : ICUser
    {
        public static List<User> Users = new List<User>();
        public void CreateUser(int Id, string Name, string Email)
        {
            User newuser = new User();
            newuser.id = Id;
            newuser.name = Name;
            newuser.email = Email;
            Users.Add(newuser);
        }

        public void UpdateUser(User userToChange, int Id, string Name, string Email)
        {
            userToChange.id = Id;
            userToChange.name = Name;
            userToChange.email = Email;
        }

        public void DeleteUser(User user)
        {
            user = null;
        }

        public List<User> GetUsers()
        {
            return Users;
        }
    }
}
