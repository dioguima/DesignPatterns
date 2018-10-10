using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class HexObserver : Observer
    {
        public HexObserver(Input input) : base(input) { }

        public override void Update()
        {
            Console.WriteLine(this.input.Value.ToString("X"));
        }
    }
}
