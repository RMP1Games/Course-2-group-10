using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _140325.Models;

namespace _140325.Services.Interfaces
{
    internal interface ICUser
    {
        void CreateUser(int Id, string Name, string Email);
        void UpdateUser(User userToChange, int Id, string Name, string Email);
        void DeleteUser(User user);
    }
}
