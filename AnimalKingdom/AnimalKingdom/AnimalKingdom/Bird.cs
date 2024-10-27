using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    internal class Bird : Animal
    {
        //Make Sound function override for specific animal
        public override void MakeSound() 
        {
            Console.WriteLine("Chirp");
        }
        //Eat function override for specific animal
        public override void Eat()
        {
            Console.WriteLine("This bird eats seeds.");
        }
    }
}