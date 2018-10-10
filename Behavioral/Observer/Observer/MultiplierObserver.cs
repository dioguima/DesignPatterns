using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class MultiplierObserver : Observer
    {
        public MultiplierObserver(Input input) : base(input) { }

        public override void Update()
        {
            Console.WriteLine(this.input.Value * 10);
        }
    }
}
