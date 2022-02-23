using System;

namespace class1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            cat.name = "pisicik";
            cat.weight = 4;
            cat.gender = 1;
            Console.WriteLine(cat.GetAnimalProperties());
            
            Animal bird = new Animal();
            bird.name = "kanarya";
            bird.weight = 1;
            bird.gender = 0;
            Console.WriteLine(bird.GetAnimalProperties());
            
            Animal dog = new Animal();
            Console.WriteLine(dog.GetAnimalProperties());

        }
    }
}