using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using _140325.Models;
using _140325.Controllers;

namespace _140325.Services
{
    internal class Search
    {
        public List<User> UserSearch(string email)
        {
            return CUser.Users.Where(r => r.email == email).ToList();
        }

        public List<Book> BookSearch(string Name, int YearOfCreate)
        {
            return CBook.Books.Where((r => ((r.name == Name) && (r.yearOfCreate == YearOfCreate)))).ToList();
        }
    }
}
