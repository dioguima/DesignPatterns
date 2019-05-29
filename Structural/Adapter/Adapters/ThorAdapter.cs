using Adapter.Warriors;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Adapters
{
    class ThorAdapter : IWarrior
    {
        private readonly Thor thor;
        private readonly EWeapon eWeapon;

        public ThorAdapter(EWeapon eWeapon)
        {
            thor = new Thor();
            this.eWeapon = eWeapon;
        }

        public void Attack()
        {
            thor.Attack(eWeapon);
        }

    }
}
