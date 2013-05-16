using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPAnimals1
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        override public void Walk()
        {
            Console.WriteLine(string.Format("Dog {0} walk", Name));
        }

        override public void Talk()
        {
            Console.WriteLine(string.Format("Dog {0} talk: Woof!", Name));
        }
    }
}
