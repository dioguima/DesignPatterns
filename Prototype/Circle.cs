using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class Circle : GameObjectPrototype
    {
        private int x;
        private int y;

        public override EObjectType ObjectType { get => EObjectType.Circle; }

        private Circle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override IGameObject Clone()
        {
            return new Circle(0, 0);
        }
    }
}
