using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBook.Models
{
    public class Library
    {
        public int Id { get; set; }
        public static int SId { get; set; }
        public string Name { get; set; }

        public List<Book> books = new List<Book>();

        private static List<Library> libraries = new List<Library>();


        public Library(string name)
        {
            Name=name;
            SId++;
            Id=SId;
        }

        public static void AddLibraryList(Library library)
        {

            libraries.Add(library);

        }

        public void GetLibraryInfo()
        {
            Console.WriteLine($"{Id} - {Name} \n");

            foreach (var item in books)
            {
                Console.WriteLine($"{item.Id} -- {item.Name} -- {item.Author}");
            }
            Console.WriteLine("\n");
        }

        public static void GetAllInfo()
        {
            foreach (var item in libraries)
            {
                Console.WriteLine($"{item.Id} -- {item.Name}\n");
                foreach (var item2 in item.books)
                {
                    Console.WriteLine($"{item2.Id} -- {item2.Name} -- {item2.Author}");
                }
                Console.WriteLine("\n");
            }
            

        }

    }
}
