using System;
using System.Collections.Generic;

namespace OOPAnimals1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteHeader("Jedan objekat, klasika");

            var myCat = new Cat("Garfield");
            myCat.Walk();
            myCat.Talk();


            WriteHeader("Više objekata (znamo tip u compile time)");            

            var animals = new List<Animal>
                              {
                                  new Cat("Garfield"),
                                  new Dog("Locko"),
                                  new Dog("Pajko")
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
