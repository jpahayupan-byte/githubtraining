using library.services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.services.Interfaces
{
    public interface IBookServices
    {
        public void AddBooks(BookViewModel book);
        public void DisplayAllBoooks();
    }
}
