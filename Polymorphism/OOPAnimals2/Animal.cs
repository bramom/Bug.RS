using System;

namespace OOPAnimals2
{
    public abstract class Animal
    {
        public string Name;

        protected Animal(string name)
        {
            Name = name;
        }

        public Animal Walk()
        {
            Console.Write("Prepare for walk. ");
            DoWalk();
            return this;
        }

        public abstract void DoWalk();

        public Animal Talk()
        {
            Console.Write("Prepare for talk. ");
            DoTalk();
            return this;
        }

        public abstract void DoTalk();
    }
}
