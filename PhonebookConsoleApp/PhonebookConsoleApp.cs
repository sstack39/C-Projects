/*
Name: Sean Stack
COP2360 - Assignment 3 - Grading System
Sept 01, 2024
Collaboration Statement: I worked on this alone
 */




using System;

using System.IO;

class phonebookconsoleapp

{

    static void Main(string[] args)

    {

        string fileName = "phonebook.txt";

        while (true)

        {
            //prompt the user for a name to add to the phone book with a directory menu to select from
            Console.WriteLine(" ");
            Console.WriteLine("Phone Book Menu:");

            Console.WriteLine("1. Add Name");

            Console.WriteLine("2. View Names");

            Console.WriteLine("3. Exit");

            Console.WriteLine(" ");

            Console.Write("Please enter your choice: ");

            //use console.readline in order for program to recognize user input entered
            string userInput = Console.ReadLine();

            switch (userInput)

            {

                case "1":

                    AddName(fileName);

                    break;

                case "2":

                    ViewNames(fileName);

                    break;

                case "3":

                    Environment.Exit(0);

                    break;

                default:
                    Console.WriteLine(" ");
                    Console.WriteLine("Invalid choice. Please try again.");

                    break;

            }

        }

    }

    static void AddName(string fileName)

    {

        Console.WriteLine(" ");
        Console.Write("Enter name: ");

        string name = Console.ReadLine();
        Console.WriteLine(" ");
        Console.Write("Enter phone number: ");

        string phoneNumber = Console.ReadLine();

        //use streamwriter to append this name to the phonebook.txt
        //save to the same directory as the project file

        using (StreamWriter writer = new StreamWriter(fileName, true))

        {
            //when writing names to the text file format string using a tab (\t) so it writes name [a tab indentation] phone number
            writer.WriteLine($"{name}\t{phoneNumber}");

        }

        Console.WriteLine(" ");
        Console.WriteLine("Name added successfully!");

    }

    static void ViewNames(string fileName)

    {

        if (!File.Exists(fileName))

        {

            Console.WriteLine("Phone book is empty.");

            return;

        }

        Console.WriteLine(" ");
        Console.WriteLine("Phone Book Entries:");

        using (StreamReader reader = new StreamReader(fileName))

        {

            string line;

            while ((line = reader.ReadLine()) != null)

            {
                //read and display all names from phonebook.txt using streamreader

                Console.WriteLine(line);

            }

        }

    }

}