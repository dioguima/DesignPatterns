using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface IEnemy
    {
        void Attack();
        void Heal();
        void Die();
    }
}
