using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reference: https://sourcemaking.com/design_patterns/singleton
            Singleton singleton = Singleton.Instance;
            Console.WriteLine($"Initial name: {singleton.Name}");
            singleton.Name = "Jane Doe";
            Console.WriteLine($"Changed name: {singleton.Name}");
            Singleton anotherSingleton = Singleton.Instance;
            Console.WriteLine($"Name in another variable: {anotherSingleton.Name}");
            Console.Read();
        }
    }
}
