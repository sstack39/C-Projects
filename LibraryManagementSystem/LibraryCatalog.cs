using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public static class LibraryCatalog
    {
        public static List<Book> books { get; private set; } = new List<Book>();
        public static void AddBook(Book book)
        {
            books.Add(book);
        }
        public static void CheckInBook(string Title)
        {
            int BooksWithTitle = books.Count(book => book.Title == Title);
            if (BooksWithTitle == 0)
            {
                Console.WriteLine("No books with this title are available");
            }
            else
                GetBook(Title).CheckIn();
        }
        public static void CheckOutBook(string Title)
        {
            int BooksWithTitle = books.Count(book => book.Title == Title);
            if (BooksWithTitle == 0)
            {
                Console.WriteLine("No books with this title are available");
            }
            else
                GetBook(Title).CheckOut();
        }
        public static void ListBooks()
        {
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine($"Title: {books[i].Title}");
                Console.WriteLine($"Author: {books[i].Author}");
                Console.WriteLine($"Checked out: {books[i].IsCheckedOut}");
                Console.WriteLine("-------------------");

            }
        }

        private static Book GetBook(string Title)
        {
            
            return books.FirstOrDefault(book => book.Title == Title);
        }
        

    }
}
