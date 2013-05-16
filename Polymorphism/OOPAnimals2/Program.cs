using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPAnimals2
{
    class Program
    {
        static void Main(string[] args)
        {            
            WriteHeader("Jedan objekat, klasika");

            var myCat = new Cat("Garfield");
            myCat.Walk();
            myCat.Talk();


            WriteHeader("Jedan objekat, oneliner");

            new Cat("Garfield").Walk().Talk();


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


            WriteHeader("Više objekata, tip se određuje u runtime");

            var animalsNameType = new Dictionary<string, string>
                                      {
                                          {"Garfield", "Cat"},
                                          {"Locko", "Dog"},
                                          {"Pajko", "Dog"}
                                      };

            foreach (var pair in animalsNameType)
            {
                var animal = AnimalFactory.Create(pair.Value, pair.Key);

                animal.Walk();
                animal.Talk();
            }


            WriteHeader("Više objekata, tip se određuje u runtime, oneliner");

            animalsNameType.ToList().ForEach(
                    pair =>
                        AnimalFactory.Create(pair.Value, pair.Key)
                            .Walk()
                            .Talk()
                );
            
            Console.Read();
        }

        private static void WriteHeader(string message)
        {
            Console.WriteLine();
            Console.WriteLine(string.Format("/* {0} */", message));
        }
    }
}
