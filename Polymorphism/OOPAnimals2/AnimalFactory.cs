using System;
using System.Collections.Generic;

namespace OOPAnimals2
{
    public class AnimalFactory
    {
        private static readonly Dictionary<string, Func<string, Animal>> animalConstructors =
            new Dictionary<string, Func<string, Animal>>()
                    {
                        {"Cat", n => new Cat(n)},
                        {"Dog", n => new Dog(n)}
                    };

        public static Animal Create(string type, string name)
        {
            return animalConstructors[type](name);
        }
    }
}
