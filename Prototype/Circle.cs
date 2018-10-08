using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class Circle : IGameObjectPrototype
    {
        private int x;
        private int y;

        public EObjectType ObjectType { get => EObjectType.Circle; }

        public Circle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public IGameObjectPrototype Clone()
        {
            return new Circle(x, y);
        }
    }
}
