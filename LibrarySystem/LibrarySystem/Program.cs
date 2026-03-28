using library.services.Interfaces;
using library.services.Service;
using library.services.ViewModels;
using Sample;
using System.Reflection;

namespace Sample
{
  
    //public class Book
    //{

    //    private string ID { get; set; } = Guid.NewGuid().ToString();

    //    public string Title { get; set; }
    //    public string Description { get; set; }
    //    public string PublishDate { get; set; }

    //    public Author Author { get; set; }

    //    public Book(string title, string description)
    //    {
    //        Title = title;
    //        Description = description;

    //    }
    //    public void DisplayInfo()
    //    {
    //        Console.WriteLine($"ID: {ID}" + "Title" + Title + $"Description: {Description}" );
    //    }
    //}

    //public class Author : BaseEntity
    //{
    //    public string Age { get; set; }
     
    //}

    //public class Publisher : BaseEntity
    //{

    //}

    //public class Library : BaseEntity
    //{

    //}
    //public class BookService
    //{
    //    private readonly BookRepository repository = new();

    //    public void Addbook(Book book)
    //    {
    //        repository.Add(book);
    //    }
    //    public void DisplayAllBook()
    //    {
    //        var books = repository.GetAllbooks();
    //        foreach (var book in books)
    //        {
    //            book.DisplayInfo();

    //        }
    //    }

    //}

    //public class BookRepository
    //{
    //    public static List<Book> listofBooks = new();
    //    public void Add(Book book)
    //    {
    //        listofBooks.Add(book);
    //    }
    //    public List<Book> GetAllbooks()
    //    {
    //        return listofBooks;
    //    }
    //}

    public class MainClass()
    {
        public static void Main()
        {
            IBookServices bookservice = new BooksService();
            while (true)
            {
                Console.WriteLine("Want to add books [Y/N]");
                var key = Console.ReadKey().KeyChar.ToString();

                if (key == "N") break;
                else if (key != "Y")
                {
                    Console.WriteLine("\nPlease select Y or N only:");
                    continue;

                }

                Console.WriteLine("\nEnter Book Name: ");
                string title = Console.ReadLine();
                Console.WriteLine("\nEnter Book Description: ");
                string description = Console.ReadLine();
                BookViewModel book = new (title, description);
                bookservice.AddBooks(book);
            }
            bookservice.DisplayAllBoooks();




            //Book book = new Book("C#", "background");
            //bookservice.Addbook(book);
            //book.Author.name = "Joshua";
            //book.Author.Age = "29";
            //Book book1 = new Book("Math", "About Math");
            //bookservice.Addbook(book1);
            //bookservice.DisplayAllBook();


        }

    }
    public abstract class BaseEntity
    {
        private string Id { get; set; } = Guid.NewGuid().ToString();

        public string name { get; set; }
        

    }


}//end of namespace








