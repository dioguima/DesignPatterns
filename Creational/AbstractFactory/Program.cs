using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory normalEnemyFactory = AbstractFactory.GetFactory(EEnemyType.Normal);
            IEnemy normalEnemy = normalEnemyFactory.MakeEnemy();
            normalEnemy.Attack();
            normalEnemy.Heal();
            normalEnemy.Die();
            AbstractFactory bigEnemyFactory = AbstractFactory.GetFactory(EEnemyType.Big);
            IEnemy bigEnemy = bigEnemyFactory.MakeEnemy();
            bigEnemy.Attack();
            bigEnemy.Heal();
            bigEnemy.Die();
            Console.Read();
        }
    }
}
