using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class BallModel
    {
        public float mass;
        public float area;

        public BallModel(ref float mass, ref float area)
        {
            this.mass = mass;
            this.area = area;
        }
    }
}
