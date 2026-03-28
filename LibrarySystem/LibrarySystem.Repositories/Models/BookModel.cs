using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Repositories.Models
{
    public class BookModel
    {
        public string Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Title { get; set; }   
        public string Description { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id} \nTitle : " + Title + $"\nDescription : {Description} ");
        }
    }
}
