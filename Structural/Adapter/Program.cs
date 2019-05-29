using Adapter.Adapters;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reference: https://sourcemaking.com/design_patterns/adapter
            IWarrior warrior = new ThorAdapter(EWeapon.Mjonir);
            warrior.Attack();
            warrior = new HulkAdapter();
            warrior.Attack();
            Console.Read();
        }
    }
}
