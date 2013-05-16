using System;

namespace OOPAnimals2
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        override public void DoWalk()
        {
            Console.WriteLine(string.Format("Dog {0} walk", Name));        
        }

        override public void DoTalk()
        {
            Console.WriteLine(string.Format("Dog {0} talk: Woof!", Name));            
        }
    }
}
