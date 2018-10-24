using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class Enemy : IEnemy
    {
        private int maxLifePoints;
        private int currentLifePoints;
        private EWeaponType weaponType;

        public Enemy(int maxLifePoints, EWeaponType weaponType)
        {
            this.maxLifePoints = maxLifePoints;
            this.currentLifePoints = maxLifePoints;
            this.weaponType = weaponType;
        }

        public void Attack()
        {
            switch (weaponType)
            {
                case EWeaponType.Gun:
                    Console.WriteLine($"Enemy attaking - 20");
                    break;
                case EWeaponType.Sword:
                    Console.WriteLine($"Enemy attaking - 15");
                    break;
                default:
                    Console.WriteLine($"Enemy doesn't have weapon");
                    break;
            }
        }

        public void Die()
        {
            Console.WriteLine($"Enemy dead");
        }

        public void Heal()
        {
            this.currentLifePoints += 10;
            if (this.currentLifePoints >= this.maxLifePoints)
            {
                this.currentLifePoints = this.maxLifePoints;
                Console.WriteLine($"Enemy full healed - {this.currentLifePoints}");
            }
            else
            {
                Console.WriteLine($"Enemy heal - {this.currentLifePoints}");
            }
        }
    }
}
