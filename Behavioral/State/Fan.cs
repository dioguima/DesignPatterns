using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Fan
    {
        public IFanState currentState { get; set; }

        public Fan()
        {
            this.currentState = new OffState();
        }

        public void IncreaseVelocity()
        {
            this.currentState.IncreaseVelocity(this);
        }

        public void DecreaseVelocity()
        {
            this.currentState.DecreaseVelocity(this);
        }
    }
}
