using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class Ball : BallModel
    {
        public Tuple<int, int> position;
        
        public Ball(BallModel ballModel, Tuple<int, int> position) : base(ref ballModel.mass, ref ballModel.area)
        {
            this.position = position;
        }
    }
}
