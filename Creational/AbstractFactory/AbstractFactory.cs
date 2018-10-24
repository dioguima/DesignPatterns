using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract IEnemy MakeEnemy();

        private static readonly NormalEnemyFactory normalEnemyFactory = new NormalEnemyFactory();
        private static readonly BigEnemyFactory bigEnemyFactory = new BigEnemyFactory();

        public static AbstractFactory GetFactory(EEnemyType enemy)
        {
            switch (enemy)
            {
                case EEnemyType.Normal:
                    return normalEnemyFactory;
                case EEnemyType.Big:
                    return bigEnemyFactory;
            }
            return null;
        }

    }

    public enum EEnemyType
    {
        Normal,
        Big
    }

    public enum EWeaponType
    {
        Gun,
        Sword
    }
}
