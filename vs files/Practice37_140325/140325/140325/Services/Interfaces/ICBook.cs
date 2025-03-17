using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _140325.Models;

namespace _140325.Services.Interfaces
{
    internal interface ICBook
    {
            void CreateUser(string Name, string Author, int YearOfCreate);
            void UpdateUser(Book bookToChange, string Name, string Author, int YearOfCreate);
            void DeleteUser(Book book);
    }
}
