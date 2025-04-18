using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _180325_.Models;

namespace _180325_.Services.Interfaces
{
    internal interface ICBook
    {
        void CreateBook(string Name, string Author, string Genre);
        void UpdateBook(Book bookToChange, string Name, string Author, string Genre);
        void DeleteBook(Book book);
        List<Book> GetBooks();   
    }
}
