using library.services.Interfaces;
using library.services.ViewModels;
using LibrarySystem.Repositories.Interfaces;
using LibrarySystem.Repositories.Models;
using LibrarySystem.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.services.Service
{
    public class BooksService : IBookServices

    {
        private readonly IBookRepository _bookRepository = new BookRepository();

        public void AddBooks(BookViewModel book)
        {
            BookModel bookModel = new BookModel();
            bookModel.Title = book.Title;
            bookModel.Description = book.Description;
            bookModel.Id = Guid.NewGuid().ToString();
            bookModel.CreatedDate = DateTime.Now;

            _bookRepository.Addbooks(bookModel);

        }
        public void DisplayAllBoooks()
        {
            var booklist = _bookRepository.GetAllBooks();
            booklist.ForEach(book =>
            {
                book.DisplayInfo();

            });
        }
    }
}

