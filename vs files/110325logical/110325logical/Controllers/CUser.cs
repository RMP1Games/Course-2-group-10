using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _110325logical.Models;

namespace _110325logical.Controllers
{
    internal class CUser
    {
        public void CreateUser(int Id, string Name, string Email)
        {
            User newuser = new User();
            newuser.id = Id;
            newuser.name = Name;
            newuser.email = Email;
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
    }
}
