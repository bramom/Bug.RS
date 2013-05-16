using System;

namespace StructuredAnimals1
{
    public class Animal
    {
        public string Name;

        public Animal(string name)
        {
            Name = name;
        }

        public void Walk(string type)
        {
            switch (type)
            {
                case "Dog":
                    Console.WriteLine(string.Format("Dog {0} walk", Name));
                    break;

                case "Cat":
                    Console.WriteLine(string.Format("Dog {0} walk", Name));
                    break;
            }
        }

        public void Talk(string type)
        {
            switch (type)
            {
                case "Dog":
                    Console.WriteLine(string.Format("Dog {0} talk: Woof!", Name));
                    break;

                case "Cat":
                    Console.WriteLine(string.Format("Cat {0} talk: Meow!", Name));
                    break;
            }
        }
    }
}
