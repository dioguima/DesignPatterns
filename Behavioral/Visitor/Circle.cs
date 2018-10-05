using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class Circle
    {
        private int x;
        private int y;
        private int radius;
        
        public Circle(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public bool IsColliding(Circle circle)
        {
            double diff = Math.Sqrt(Math.Pow(circle.x - this.x, 2) + Math.Pow(circle.y - this.y, 2));
            return diff <= circle.radius + this.radius;
        }
    }
}
