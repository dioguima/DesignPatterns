using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Warriors
{
    public class Thor
    {
        public void Attack(EWeapon? eWeapon)
        {
            if(eWeapon != null)
            {
                Console.WriteLine($"Thor attacked the enemy with {eWeapon.ToString()}");
            }
            else
            {
                Console.WriteLine("Thor attacked the enemy with his bare hands");
            }
        }
    }
}
