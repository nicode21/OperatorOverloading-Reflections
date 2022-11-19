using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBook.Models
{
    public class Book
    {
        public string? Name { get; set; }
        public string? Author { get; set; }
        public static int SId { get; set; }
        public int Id { get; set; }

        public Book(string name, string author)
        {
            Name = name;
            Author = author;
            SId++;
            Id=SId;
        }
    }
}
