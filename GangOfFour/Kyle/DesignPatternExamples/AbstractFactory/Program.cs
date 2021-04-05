using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimalFactory factory = new DogFactory();

            IAnimal a1 = factory.MakeAnimal();

            factory = new CatFactory();

            IAnimal a2 = factory.MakeAnimal();

            Console.WriteLine($"a1 says: {a1.Speak()}");
            Console.WriteLine($"a2 says: {a2.Speak()}");
        }
    }
}
