using LibrarySystem.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Repositories.Interfaces
{
public interface IBookRepository
    {
        public void Addbooks(BookModel bookModel);
        public List<BookModel> GetAllBooks();
    }
}
