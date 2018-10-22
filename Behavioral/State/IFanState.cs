using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    interface IFanState
    {
        void IncreaseVelocity(Fan fan);
        void DecreaseVelocity(Fan fan);
    }
}
