using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            EnemyBuilder normalEnemyBuilder = new EnemyBuilder().Name("Bad Guy").LifePoints(100).Type(EEnemyType.Normal).Position(new Tuple<int, int>(10, 10));
            EnemyBuilder bigEnemyBuilder = new EnemyBuilder().Name("Big Bad Guy").LifePoints(300).Type(EEnemyType.Big).Position(new Tuple<int, int>(10, 10));
            Enemy normalEnemy = normalEnemyBuilder.Build();
            Console.WriteLine($"{normalEnemy.Name} created");
            Enemy bigEnemy = bigEnemyBuilder.Build();
            Console.WriteLine($"{bigEnemy.Name} created");
            Console.Read();
        }
    }
}
