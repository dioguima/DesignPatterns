using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public interface IGameObject
    {
        EObjectType ObjectType { get; }

        IGameObject Clone();
    }

    public enum EObjectType
    {
        Circle,
        Rectangle
    }
}
