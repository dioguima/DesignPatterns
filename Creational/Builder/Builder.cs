using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class EnemyBuilder
    {
        public string EnemyName { get; private set; }
        public float EnemyLifePoints { get; private set; }
        public Tuple<int, int> EnemyPosition { get; private set; }
        public EEnemyType EnemyType { get; set; }

        public EnemyBuilder Name(string name)
        {
            this.EnemyName = name;
            return this;
        }

        public EnemyBuilder LifePoints(float lifePoints)
        {
            this.EnemyLifePoints = lifePoints;
            return this;
        }

        public EnemyBuilder Position(Tuple<int, int> position)
        {
            this.EnemyPosition = position;
            return this;
        }

        public EnemyBuilder Type(EEnemyType enemyType)
        {
            this.EnemyType = enemyType;
            return this;
        }

        public Enemy Build()
        {
            return new Enemy(this);
        }
    }
}
