



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaracaEncryptionAlgorithim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Encode("banana"));
            Console.ReadLine();
        }

       
        public readonly string Encode(string word)
        {
            //set string variable to copy input and reverse 
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            string ReversedWord = new string(charArray);

            //create stringbuilder to replace vowels passing ReversedWord variable within
            StringBuilder sb = new StringBuilder(ReversedWord);
            // a => 0
            sb.Replace("a", "0");
            // e => 1
            sb.Replace("e", "1");
            // i => 2
            sb.Replace("i", "2");
            // o => 2
            sb.Replace("o", "2");
            // u => 3
            sb.Replace("u", "3");

            //append the sb by adding "aca" at the end 

            sb.Append("aca");

            //return entire sb to console

            return sb.ToString();
        }
    }
}
