using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _110325logical.Models;

namespace _110325logical.Controllers
{
    internal class CBook
    {
        public void CreateBook(string Name, string Author, int YearOfCreate)
        {
            Book newbook = new Book();
            newbook.name = Name;
            newbook.author = Author;
            newbook.yearOfCreate = YearOfCreate;
        }

        public void UpdateBook(Book bookToChange, string Name, string Author, int YearOfCreate)
        {
            bookToChange.name = Name;
            bookToChange.author = Author;
            bookToChange.yearOfCreate = YearOfCreate;
        }

        public void DeleteBook(Book book)
        {
            book = null;
        }
    }
}
