using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using _180325_.Models;
using _180325_.Controllers;

namespace _180325_.Services
{
    internal class Search
    {
        public List<User> UserSearch(string Email, string Name)
        {
            return CUser.Users.Where(r => (r.email == Email) && (r.name == Name)).ToList();
        }

        public List<Book> BookSearch(string Name,string Author, string Genre)
        {
            return CBook.Books.Where(r => (r.name == Name) && (r.genre == Genre) && (r.author == Author)).ToList();
        }
    }
}
