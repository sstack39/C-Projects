namespace AnimalKingdom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> Zoo = new List<Animal>() //create list of animal types to reference each class type
            {
                new Bird{Name = "Parrot"}, 
                new BigCat{Name = "Lion"},
                new Dog{Name = "Husky"},
            };
            foreach (var animal in Zoo) //for each animal object in the zoo list
            {
                Console.WriteLine(animal.Name);
                animal.MakeSound();
                animal.Eat();
            }
            
        }
    }
}
