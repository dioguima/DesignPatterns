﻿using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reference: https://sourcemaking.com/design_patterns/visitor
            IGameObjectPrototype circle = Factory.GetPrototype(EObjectType.Circle);
            if(circle != null)
            {
                Console.WriteLine("Circle found");
            }
            IGameObjectPrototype rectangle = Factory.GetPrototype(EObjectType.Rectangle);
            if (rectangle != null)
            {
                Console.WriteLine("Rectangle found");
            }
            Console.Read();
        }
    }
}
