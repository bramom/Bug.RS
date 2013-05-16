using System;
using LicenceLibrary;

namespace SignedAssemblySample
{
    class Program
    {
        static void Main(string[] args)
        {
            Licence licence = new Licence();

            Console.WriteLine("First attempt, result: {0}", 
                licence.Validate("invalid key"));
            Console.WriteLine("Second attempt, result: {0}", 
                licence.Validate("valid key"));

            Console.Read();
        }
    }
}
