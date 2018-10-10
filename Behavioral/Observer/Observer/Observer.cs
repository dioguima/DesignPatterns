using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public abstract class Observer
    {
        protected Input input;

        protected Observer(Input input)
        {
            this.input = input;
            input.AddObserver(this);
        }

        public abstract void Update();
    }
}
