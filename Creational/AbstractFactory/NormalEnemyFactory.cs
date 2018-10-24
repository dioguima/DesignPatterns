using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class NormalEnemyFactory : AbstractFactory
    {
        public override IEnemy MakeEnemy()
        {
            return new Enemy(100, EWeaponType.Gun);
        }
    }
}
