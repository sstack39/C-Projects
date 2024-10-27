



using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CarRentalCompany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //call rental manager code by referencing each vehicle type
            RentalManager rm = new RentalManager();
            // define attributes of a specific car
            rm.AddVehicle(new Car("Ford", "Fiesta", "2004"));

            // define attributes of a specific boat
            rm.AddVehicle(new Boat("Honda", "WaveRider", "2011"));

            //define attributes of a specific motor bike
            rm.AddVehicle(new Bike("Honda", "CrotchRocket2000", "2016"));

            int choice = 0;
            //incorporate a while loop with to run through menu options for user
            while (choice != 6)
            {
                Console.Clear();
                Console.WriteLine("1 - View all vehicles");
                Console.WriteLine("2 - View available vehicles");
                Console.WriteLine("3 - View unavailable vehicles");
                Console.WriteLine("4 - Rent a vehicle");
                Console.WriteLine("5 - Return a vehicle");
                Console.WriteLine("6 - Exit");
                Console.WriteLine(" ");
                Console.Write("Enter your choice: ");
                //incorporate the appropriate forms of error handling within nested while loop
                while (int.TryParse(Console.ReadLine(),out choice) == false || choice < 1 || choice > 6) 
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
                        rm.ShowAllVehicles();
                        Console.WriteLine("Enter to continue: ");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        rm.ShowVehiclesByStatus("Available");
                        Console.WriteLine("Enter to continue: ");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        rm.ShowVehiclesByStatus("Unavailable");
                        Console.WriteLine("Enter to continue: ");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Clear();
                        rm.RentVehicle();
                        Console.WriteLine("Enter to continue: ");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.Clear();
                        rm.ReturnVehicle();
                        Console.WriteLine("Enter to continue: ");
                        Console.ReadLine();
                        break;
                  
                }
            }
        }

    }
}
