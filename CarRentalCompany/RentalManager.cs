using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalCompany
{
    //create RentalManager.cs 
    public class RentalManager
    {
        //use list type to store vehicle information + new or changed info
        public List<Vehicle> AllVehicles { get; private set; } = new List<Vehicle>();

        public void AddVehicle(Vehicle vehicle)
        {
            AllVehicles.Add(vehicle);

        }
        public void RemoveVehicle(Vehicle vehicle) 
        {
            AllVehicles.Remove(vehicle);
        }

        public void RentVehicle() 
        {
            Console.WriteLine("Enter the number of vehicle to rent: ");
            List<Vehicle> unrented = ShowVehiclesByStatus("Available");
            //define choice and utilize while loop to tryparse user input in order to determine status
            //utilize this structure to also address appropriate error handling for user experience
            int choice;
            while (int.TryParse(Console.ReadLine(), out choice) == false || choice < 1 || choice > unrented.Count)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Invalid Input, please try again: ");

            }
            //use specific formatting details in order to make displayed information easily read by user
            Vehicle vehicle = unrented[choice -1];
            vehicle.Rent(this);
            Console.Clear();
            Console.WriteLine("Vehicle has been rented: ");
            Console.WriteLine("------------------------");
            vehicle.ShowInfo();
            Console.WriteLine("------------------------");


        }

        public void ReturnVehicle() 
        {
            Console.WriteLine("Enter the number of vehicle to return: ");
            List<Vehicle> rented = ShowVehiclesByStatus("Unavailable");
            int choice;
            while (int.TryParse(Console.ReadLine(), out choice) == false || choice < 1 || choice > rented.Count)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Invalid Input, please try again: ");

            }
            Vehicle vehicle = rented[choice -1];
            vehicle.Return(this);
            Console.Clear();
            Console.WriteLine("Vehicle has been returned: ");
            Console.WriteLine("------------------------");
            vehicle.ShowInfo();
            Console.WriteLine("------------------------");
        }
        public void ShowAllVehicles()
        {
            Console.WriteLine("All Vehicles : ");
            Console.WriteLine(" ");

            //use for loop in order to run through list of stored vehicle data to be properly displayed
            for (int i = 0; i < AllVehicles.Count; i++)
            {
                AllVehicles[i].ShowInfo();
                Console.WriteLine("------------------------");

            }
            
        }
        //define vehicle list by literally displaying each vehicle as directed by the user with a particular status (avail or unavail.)
        public List<Vehicle> ShowVehiclesByStatus(string Status)
        {
            List<Vehicle> Vehicles = (List<Vehicle>)AllVehicles.Where(a => a.Status == Status).ToList();

            Console.WriteLine($"{Status} Vehicles : ");
            Console.WriteLine(" ");


            for (int i = 0; i < Vehicles.Count; i++)
            {

                Console.WriteLine($"-----Vehicle #{(i + 1)}------");
                Vehicles[i].ShowInfo();
                Console.WriteLine("------------------------");

            }
            return Vehicles;
        }

    }

}
