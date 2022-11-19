using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Models;
using Training.Services.Interfaces;

namespace Training.Services
{
    public class BookService : IBookService
    {
        public int GetCount(Predicate<Book> predicate)
        {

            var books = GetAll();

            return books.FindAll(predicate).Count;

        }

        private List<Book> GetAll()
        {
            List<Book> books = new List<Book>();

            Book book1 = new()
            {
                Name= "Iskendername",
                Author = "Nizami"
            };
            Book book2 = new()
            {
                Name = "Shikayetname",
                Author = "Fizuli"
            };
            Book book3 = new()
            {
                Name = "Xosrov ve Shirin",
                Author = "Nizami"
            };
            Book book4 = new()
            {
                Name = "Ferhad ve Shirin",
                Author = "Fizuli"
            };
            Book book5 = new()
            {
                Name = "Sevil",
                Author = "Huseyin Cavid"
            };

            books.Add(book1);
            books.Add(book2);
            books.Add(book3);
            books.Add(book4);
            books.Add(book5);

            return books;

        }
    }
}
