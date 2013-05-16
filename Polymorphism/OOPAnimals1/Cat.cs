using System;

namespace OOPAnimals1
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        override public void Walk()
        {
            Console.WriteLine(string.Format("Cat {0} walk", Name));
        }

        override public void Talk()
        {
            Console.WriteLine(string.Format("Cat {0} talk: Meow!", Name));
        }
    }
}
