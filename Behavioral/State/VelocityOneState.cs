using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class VelocityOneState : IFanState
    {
        public void DecreaseVelocity(Fan fan)
        {
            fan.currentState = new OffState();
            Console.WriteLine("Velocity changed: Fan turned off");
        }

        public void IncreaseVelocity(Fan fan)
        {
            fan.currentState = new VelocityTwoState();
            Console.WriteLine("Velocity changed: 1 => 2");
        }
    }
}
