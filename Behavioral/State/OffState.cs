using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class OffState : IFanState
    {
        public void DecreaseVelocity(Fan fan)
        {
            Console.WriteLine("The fan is already off");
        }

        public void IncreaseVelocity(Fan fan)
        {
            fan.currentState = new VelocityOneState();
            Console.WriteLine("Velocity changed: Fan turned on");
        }
    }
}
