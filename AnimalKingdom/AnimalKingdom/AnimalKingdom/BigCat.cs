using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    internal class BigCat : Animal
    {
        //Make Sound function override for specific animal
        public override void MakeSound()
        {
            Console.WriteLine("Roar");
        }
        //Eat function override for specific animal
        public override void Eat()
        {
            Console.WriteLine("This big cat eats meat.");
        }
    }
}