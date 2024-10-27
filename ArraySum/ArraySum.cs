/*
Name: Sean Stack
COP2360 - Assignment 7 - Array Sum Program
Sept 09, 2024
Collaboration Statement: I worked on this alone
 */



using System.ComponentModel;

namespace ArraySum
{
    internal class Program
    {
        //utilize static void main method for argument
        static void Main(string[] args)
        {
            double cumulative = 0;
            Random rand = new Random();
            int[] values = new int[10];
            //utilize for loop and System.Random.Next(100) to generate random values between 1 and 100
            for (int i = 0; i < values.Length; i++)
            {
                
                values[i] = rand.Next(100);
                cumulative += values[i];
                //display randomly generated number values to user as result
                Console.WriteLine($"Value: {values[i]} Cumulative total: {cumulative} ");
            }
        }
    }
}
