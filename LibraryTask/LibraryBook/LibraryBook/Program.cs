

using LibraryBook.Models;
using static LibraryBook.Models.Library;

Book book1 = new Book("Xosrov1","Nizami1");
Book book2 = new Book("Xosrov2", "Nizami2");
Book book3 = new Book("Xosrov3", "Nizami3");
Book book4 = new Book("Xosrov4", "Nizami4");


Library library1 = new Library("Library1");
Library library2 = new Library("Library2");

library1.books.Add(book1);
library1.books.Add(book2);
library2.books.Add(book3);
library2.books.Add(book4);

AddLibraryList(library1);
AddLibraryList(library2);

//library1.GetLibraryInfo();
//library2.GetLibraryInfo();

GetAllInfo();
