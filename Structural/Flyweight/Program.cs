using System;
using System.Collections.Generic;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            //References: https://sourcemaking.com/design_patterns/flyweight
            //            http://gameprogrammingpatterns.com/flyweight.html
            List<Ball> balls = new List<Ball>();

            Factory factory = new Factory();
            for (int i = 0; i < 1000000; i++)
            {
                balls.Add(factory.MakeBall(new Tuple<int, int>(i, i)));
            }
            
            Console.Read();
        }
    }
}
