using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Enemy
    {
        public string Name { get; set; }
        public float LifePoints { get; set; }
        public Tuple<int, int> Position { get; set; }
        public EEnemyType EnemyType { get; set; }

        public Enemy(EnemyBuilder enemyBuilder)
        {
            this.Name = enemyBuilder.EnemyName;
            this.LifePoints = enemyBuilder.EnemyLifePoints;
            this.Position = enemyBuilder.EnemyPosition;
            this.EnemyType = enemyBuilder.EnemyType;
        }
    }

    enum EEnemyType
    {
        Normal,
        Big
    }
}
