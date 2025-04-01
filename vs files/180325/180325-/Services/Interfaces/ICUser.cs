using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _180325_.Models;

namespace _180325_.Services.Interfaces
{
    internal interface ICUser
    {
        void CreateUser(int Id, string Name, string Email);
        void UpdateUser(User userToChange, int Id, string Name, string Email);
        void DeleteUser(User user);
        List<User> GetUsers();
    }
}
