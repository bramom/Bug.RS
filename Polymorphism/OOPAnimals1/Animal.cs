using System;

namespace OOPAnimals1
{
    public abstract class Animal
    {
        public string Name;

        protected Animal(string name)
        {
            Name = name;
        }

        public abstract void Walk();

        public abstract void Talk();
    }
}
