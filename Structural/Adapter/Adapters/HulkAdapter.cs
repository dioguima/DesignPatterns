using Adapter.Warriors;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Adapters
{
    public class HulkAdapter : IWarrior
    {
        private readonly Hulk hulk;

        public HulkAdapter()
        {
            hulk = new Hulk();
        }

        public void Attack()
        {
            hulk.Smash();
        }

    }
}
