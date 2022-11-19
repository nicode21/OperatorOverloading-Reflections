using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Services;
using Training.Services.Interfaces;

namespace Training.Controllers
{
    public class BookController
    {
        public static void GetCount()
        {
            IBookService bookService = new BookService();

            Console.WriteLine(bookService.GetCount(m=>m.Author=="Huseyin Cavid"));
        }
    }
}
