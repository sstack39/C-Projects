/*
Name: Sean Stack
COP2360 - Assignment 6 - Sum Polygon Program
Sept. 09, 2024
Collaboration Statement: I worked on this alone
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;




namespace SumPolygon
{
    //utilize internal class to modularize code so that code from other assemblies may not use this class/method
    internal class Program
    {
        //this method is public static void due to the function of the method being get user input
        public static void Main(string[] args)
        {
            getInput();

        }
        //utilize private static void method to test the user input as error exception handling
        private static void getInput()
        {
            int i = 0;
            bool status = false;

            //utilize while loop to continuously test user input validity and to move forward with program functionality
            while (i <= 2)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Please enter an integer for 'n' number of sides: ");
                Console.WriteLine("\n");
                
                int n = Convert.ToInt32(Console.ReadLine());



                //utilize if/else statement as a form of error exception handling
                if (n < 2) //if n is less than 2
                {
                    
                    Console.WriteLine("Please enter a valid number of sides: ");
                    break;

                }
                else //if n is greater than 2

                {
                    Console.WriteLine("\n");
                    Console.WriteLine("PolygonSum(" + n + ") " + " => " + polygonSum(n));

                }
                i++;
               
            }
        }
        //utilize double datatype in order to properly associate the varialbe with the correct result to be displayed
        private static double polygonSum(int value)
        {
            //perform sum calculation of user input 
            double polygonSum = (value - 2) * 180;
            //utilize return funciton to return calculated result back to user as displayed result
            return polygonSum;
        }
    }
}
