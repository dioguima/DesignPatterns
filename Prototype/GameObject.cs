using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    abstract class GameObjectPrototype : IGameObject
    {
        public abstract EObjectType ObjectType { get; }

        public partial IGameObject Clone()
        {

        }
    }
}
