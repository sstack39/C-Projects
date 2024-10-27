using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ReverseCapitalize
{
    public class ReverseCapitalize
    {
        private static string reversedCapitalString = "";


        public static void Main(String[] args)
        {
            while (true)
            {


                Console.WriteLine("Please enter an all lowercase string argument: ");
                string userInput = Console.ReadLine();
                reversedCapitalString = PerformReverseandCapitalize(userInput);
                Console.WriteLine("\t");
                Console.WriteLine("\t");
                Console.WriteLine("the resulting string argument is " + reversedCapitalString);
                Console.WriteLine("\t");
            }

        }
            private static string PerformReverseandCapitalize(string input)
            {
                string reversedString = "";
                string finalString = "";

                reversedString = Reverse(input);

                finalString = Capitalize(reversedString);
                return finalString;

            }
            private static string Capitalize(string input)
            {
                string reversedString = "";
                reversedString = input.ToUpper();
                return reversedString;


            }
            private static string Reverse(string input)
            {
                string reversedString = "";

                char[] stringArray = input.ToCharArray();
                Array.Reverse(stringArray);
                string reversedStr = new string(stringArray);
                return reversedStr;


            }
        

    }
}