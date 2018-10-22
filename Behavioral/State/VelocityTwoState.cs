using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class VelocityTwoState : IFanState
    {
        public void DecreaseVelocity(Fan fan)
        {
            fan.currentState = new VelocityOneState();
            Console.WriteLine("Velocity changed: 2 => 1");
        }

        public void IncreaseVelocity(Fan fan)
        {
            Console.WriteLine("It's not possible to increase the velocity anymore");
        }
    }
}
