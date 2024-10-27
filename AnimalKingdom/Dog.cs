using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    internal class Dog : Animal
    {
        //Make Sound function override for specific animal
        public override void MakeSound()
        {
            Console.WriteLine("Woof");
        }
        //Eat function override for specific animal
        public override void Eat()
        {
            Console.WriteLine("This dog eats dog food.");
        }
    }
}
