using LibrarySystem.Repositories.Interfaces;
using LibrarySystem.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Repositories.Repositories
{
    public class BookRepository : IBookRepository
    {
        public static List<BookModel> books = new();
        public void Addbooks(BookModel bookModel)
        {
          GetAllBooks().Add(bookModel);
        }

        public List<BookModel> GetAllBooks()
        {
            return books;
        }
    }
}
