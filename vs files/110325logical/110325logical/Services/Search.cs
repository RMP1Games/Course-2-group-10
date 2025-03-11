using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using _110325logical.Models;
using _110325logical.Controllers;

namespace _110325logical.Services
{
    internal class Search
    {
        public List<User> UserSearch(string email)
        {
            List<User> Users = GetUsers();//не особо понял, что такое getusers
            return Users.Where(r => r.email == email).ToList();
        }

        public List<Book> BookSearch(string Name, int YearOfCreate)
        {
            List<Book> Books = GetBooks();
            return Books.Where((r => ((r.name == Name) && (r.yearOfCreate == YearOfCreate)))).ToList();
        }
    }
}
