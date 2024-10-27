

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            //incorporate a while loop with to run through menu options for user
            while (choice != 4)
            {
                Console.Clear();
                Console.WriteLine("1 - Add Book");
                Console.WriteLine("2 - Check Out Book");
                Console.WriteLine("3 - Check In Book");
                Console.WriteLine("4 - Exit");
                Console.WriteLine(" ");
                Console.Write("Enter your choice: ");
                //incorporate the appropriate forms of error handling within nested while loop
                while (int.TryParse(Console.ReadLine(), out choice) == false || choice < 1 || choice > 6)
                {
                    Console.WriteLine(" ");
                    //incorporate the appropriate forms of error handling
                    Console.WriteLine("Invalid Input, please try again: ");

                }



                //utilize switch case within while loop for ease of operation and structure
                switch (choice)
                {
                    case 1:
                        //use clear console function to display only what user designates in initial selection
                        Console.Clear();
                        Console.WriteLine("Enter the book title: ");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter the book author: ");
                        string author = Console.ReadLine();
                        Book book = new Book(title, author);
                        LibraryCatalog.AddBook(book);
                        Console.WriteLine("Added Book! Enter to Continue: ");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Enter the book title to be checked out: ");
                        LibraryCatalog.ListBooks();
                        string title1 = Console.ReadLine();
                        LibraryCatalog.CheckOutBook(title1);
                        Console.WriteLine("Enter to continue: ");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Enter the book title to be checked out: ");
                        LibraryCatalog.ListBooks();
                        string title2 = Console.ReadLine();
                        LibraryCatalog.CheckInBook(title2);
                        Console.WriteLine("Enter to continue: ");
                        Console.ReadLine();
                        break;
                    

                }
            }
        }
    }

}
