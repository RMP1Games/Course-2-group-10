using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _140325.Models;

namespace _140325.Controllers
{
    internal class CBook
    {
        public static List<Book> Books = new List<Book>();
        public void CreateBook(string Name, string Author, int YearOfCreate)
        {
            Book newbook = new Book();
            newbook.name = Name;
            newbook.author = Author;
            newbook.yearOfCreate = YearOfCreate;
            Books.Add(newbook);
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
