using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reference: https://sourcemaking.com/design_patterns/visitor
            Circle circleA = new Circle(5, 5, 5);
            Circle circleB = new Circle(15, 5, 5);
            Circle circleC = new Circle(16, 11, 5);

            //This circle should be colliding in the bottom
            Console.WriteLine(circleA.IsColliding(circleB));

            //This circle should not be colliding with any other
            Console.WriteLine(circleA.IsColliding(circleC));

            Console.Read();
        }
    }
}
