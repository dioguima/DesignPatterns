using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class BigEnemyFactory : AbstractFactory
    {
        public override IEnemy MakeEnemy()
        {
            return new Enemy(200, EWeaponType.Sword);
        }
    }
}
