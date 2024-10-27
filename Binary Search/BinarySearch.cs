/*
Name: Sean Stack
COP2360 - Assignment 8 - Binary Search Program
Sept 09, 2024
Collaboration Statement: I worked on this alone
 */

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialize list and assign horticulture terms from text document
            List<string> list = new();
            //utilize stream reader to read contents of text document
            using (StreamReader reader = new("horticulture_terms.txt"))
            {
                string? line = string.Empty;
                //utilize while loop  in order to search through text file for results
                while ((line = reader.ReadLine()) != null)
                {
                    //call specific contents to newly initialized array list
                    list.Add((string)line.ToLower());

                }
                Console.WriteLine("Please enter a search query for the horticulture terms list text file: ");
                string? input = Console.ReadLine();
                //Console.ReadLine();
                if (input != null)
                {

                    int result = list.BinarySearch(input.ToLower());
                    //utilize if/else statement as error exception handling
                    if (result == -1)
                    {
                        Console.WriteLine($"{input} was not found in the list");
                    }
                    else
                        Console.WriteLine($"{input} was in the list, and is saved at the line number: {result}");
                }
            }
        }
    }
}
