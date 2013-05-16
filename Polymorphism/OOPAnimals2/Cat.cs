using System;

namespace OOPAnimals2
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        override public void DoWalk()
        {
            Console.WriteLine(string.Format("Cat {0} walk", Name));            
        }

        override public void DoTalk()
        {
            Console.WriteLine(string.Format("Cat {0} talk: Meow!", Name));        
        }
    }
}
