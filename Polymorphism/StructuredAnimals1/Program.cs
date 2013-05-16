using System;
using System.Collections.Generic;

namespace StructuredAnimals1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteHeader("Jedan objekat, klasika");

            var myCat = new Animal("Garfield");
            myCat.Walk("Cat");
            myCat.Talk("Cat");


            WriteHeader("Više objekata");

            var animals = new List<KeyValuePair<string, Animal>>
                              {
                                  new KeyValuePair<string, Animal>("Cat", new Animal("Garfield")),
                                  new KeyValuePair<string, Animal>("Dog", new Animal("Locko")),
                                  new KeyValuePair<string, Animal>("Dog", new Animal("Pajko"))
                              };

            foreach (var animal in animals)
            {
                animal.Value.Walk(animal.Key);
                animal.Value.Talk(animal.Key);
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
