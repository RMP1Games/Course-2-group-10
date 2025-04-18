using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _180325_.Models;
using _180325_.Services.Interfaces;

namespace _180325_.Controllers
{
    internal class CBook : ICBook
    {
        public static List<Book> Books = new List<Book>();
        public void CreateBook(string Name, string Author, string Genre)
        {
            Book newbook = new Book();
            newbook.name = Name;
            newbook.author = Author;
            newbook.genre = Genre;
            Books.Add(newbook);
        }

        public void UpdateBook(Book bookToChange, string Name, string Author, string Genre)
        {
            bookToChange.name = Name;
            bookToChange.author = Author;
            bookToChange.genre = Genre;
        }

        public void DeleteBook(Book book)
        {
            book = null;
        }

        public List<Book> GetBooks()
        {
            return Books;
        }
    }
}
