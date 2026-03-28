using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.services.ViewModels
{
    public class BookViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public BookViewModel(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }

}
