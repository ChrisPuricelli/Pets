using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet newPet = new Pet("Dog", "Test pet", "George", 41.4);
            Console.WriteLine("Name: " + newPet.name);
            Console.WriteLine("Weight: " + newPet.weight + " lbs");
            Console.WriteLine(newPet.getTag());

            Dog newDog = new Dog("Pupper", "Jimmy", 21.2);
            Console.WriteLine("\nName: " + newDog.name);
            Console.WriteLine("Weight: " + newDog.weight + " lbs");
            Console.WriteLine(newDog.getTag());
            Console.WriteLine(newDog.bark(4));

            Cat newCat = new Cat("Kitty", "John", 10.8);
            Console.WriteLine("\nName: " + newCat.name);
            Console.WriteLine("Weight: " + newCat.weight + " lbs");
            Console.WriteLine(newCat.getTag());
            Console.WriteLine(newCat.meow(2));

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
        }
    }
}
