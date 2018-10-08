using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public interface IGameObjectPrototype
    {
        EObjectType ObjectType { get; }

        IGameObjectPrototype Clone();
    }

    public enum EObjectType
    {
        Circle,
        Rectangle
    }
}
