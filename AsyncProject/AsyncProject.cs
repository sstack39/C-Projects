


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialize input variable at -1 for proper function
            int input = -1; 
            
            
            while (input != 3)
            {
                //prompt the user with different menu options to print text file to terminal
                Console.WriteLine("Select 1 for the designated file path or 2 for a custom file path entry: ");

                if (!int.TryParse(Console.ReadLine(), out input))
                {
                    //use if statement for exception handling
                    Console.WriteLine("Please enter a valid number, 1 or 2: ");
                }

                if (input == 1)
                {
                    //prompt user to select file path destination
                    String filename = @".\yerp.txt";
                    ReadAndDisplayFilesAsync(filename);

                }
                if (input == 2)
                {
                    //prompt the user to enter custom file path
                    Console.WriteLine("Enter the custom file path destination: ");
                    string filename = Console.ReadLine();
                    while (!File.Exists(filename))
                    {
                        Console.Clear();
                        Console.WriteLine("Incorrect file path entered, please try again: ");
                        filename = Console.ReadLine();
                    }
                    ReadAndDisplayFilesAsync(filename);

                }
                Console.Clear();
            }
        }
        static async void ReadAndDisplayFilesAsync(string filename)
        {
            

            Char[] buffer;

            using (var sr = new StreamReader(filename))
            {
                buffer = new Char[(int)sr.BaseStream.Length];
                await sr.ReadAsync(buffer, 0, (int)sr.BaseStream.Length);
            }

            Console.WriteLine(new String(buffer));
            Console.ReadLine();
            
        }
    }
}
