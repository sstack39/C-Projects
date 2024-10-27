using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalCompany
{

    // classes, interfaces etc.

    public interface IRentable
    {
        void Rent(RentalManager rm);
        void Return(RentalManager rm);
    }

    public abstract class Vehicle : IRentable
    {
        //define properties of IRentable that can be called through inheritance
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        //use a protected string in order to only be called upon by Models.cs and not any other 'page'
        protected string status = "Available";

        //define Status as 'get;' only due to set not being necessary through the use of the choice defined on RentalManager Page
        public string Status { get; }
        public string Notes { get; set; }


        //define all constructor attributes in order to properly structure the program for calling upon each item
        public Vehicle(string Make, string Model, string Year, string Status = "Available", string Notes = "No Notes" )
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.status = Status;
            this.Notes = Notes;

        }
        //define the ShowInfo Interface needed to format and display the information stored within the list
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"Notes: {Notes}");

       
        }

        //define the two status options (available or unavailable) that can be altered based upon user interaction with menu
        public virtual void Rent(RentalManager rm)
        {
            status = "Unavailable"; 
        }

        public virtual void Return(RentalManager rm)
        {
            status = "Available";
        }
    }
    //set and define the 3 public classes provided: car, boat, and bike to work in conjuncture with program.cs
    public class Car : Vehicle
    {
        public Car(string Make, string Model, string Year, string Status = "Available", string Notes = "No Notes") : base(Make, Model, Year, Status, Notes)
        {
        }

        public override void Rent(RentalManager rm)
        {
            base.Rent(rm);
        }

        public override void Return(RentalManager rm)
        {
            base.Return(rm);
        }
    }
    public class Boat : Vehicle
    {
        public Boat(string Make, string Model, string Year, string Status = "Available", string Notes = "No Notes") : base(Make, Model, Year, Status, Notes)
        {
        }

        public override void Rent(RentalManager rm)
        {
            base.Rent(rm);
        }

        public override void Return(RentalManager rm)
        {
            base.Return(rm);
        }
    }
    public class Bike : Vehicle
    {
        public Bike(string Make, string Model, string Year, string Status = "Available", string Notes = "No Notes") : base(Make, Model, Year, Status, Notes)
        {
        }

        public override void Rent(RentalManager rm)
        {
            base.Rent(rm);
        }

        public override void Return(RentalManager rm)
        {
            base.Return(rm);
        }
    }

}



