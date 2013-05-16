using System;

namespace StructuredAnimals2
{
    public class Animal
    {
        public string Name;
        public AnimalType Type;

        public Animal(string name, AnimalType animalType)
        {
            Name = name;
            Type = animalType;
        }

        public void Walk()
        {
            switch (Type)
            {
                case AnimalType.Dog:
                    Console.WriteLine(string.Format("Dog {0} walk", Name));
                    break;

                case AnimalType.Cat:
                    Console.WriteLine(string.Format("Dog {0} walk", Name));
                    break;
            }
        }

        public void Talk()
        {
            switch (Type)
            {
                case AnimalType.Dog:
                    Console.WriteLine(string.Format("Dog {0} talk: Woof!", Name));
                    break;

                case AnimalType.Cat:
                    Console.WriteLine(string.Format("Cat {0} talk: Meow!", Name));
                    break;
            }
        }
    }
}
