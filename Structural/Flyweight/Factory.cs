using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class Factory
    {
        private BallModel ballModel;

        public Factory()
        {
            float ballMass = 10;
            float ballArea = 20;
            this.ballModel = new BallModel(ref ballMass, ref ballArea);
        }

        public Ball MakeBall(Tuple<int, int> position)
        {
            return new Ball(ballModel, position);
        }

    }
}
