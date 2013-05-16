using System;
using System.Collections.Generic;

namespace StructuredAnimals2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteHeader("Jedan objekat, klasika");

            var myCat = new Animal("Garfield", AnimalType.Cat);
            myCat.Walk();
            myCat.Talk();


            WriteHeader("Više objekata");

            var animals = new List<Animal>
                              {
                                  new Animal("Garfield", AnimalType.Cat),
                                  new Animal("Locko", AnimalType.Dog),
                                  new Animal("Pajko", AnimalType.Dog)
                              };

            foreach (var animal in animals)
            {
                animal.Walk();
                animal.Talk();
            }

            Console.Read();
        }

        private static void WriteHeader(string message)
        {
            Console.WriteLine();
            Console.WriteLine(string.Format("/* {0} */", message));
        }
    }
}
