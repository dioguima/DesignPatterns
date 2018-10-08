using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class Factory
    {
        static Dictionary<EObjectType, IGameObjectPrototype> gameObjects;

        public static void Initialize()
        {
            gameObjects = new Dictionary<EObjectType, IGameObjectPrototype>
            {
                { EObjectType.Circle, new Circle(0, 0) }
            };
        }

        public static IGameObjectPrototype GetPrototype(EObjectType objectType)
        {
            if(gameObjects == null)
            {
                Initialize();
            }

            if (gameObjects.ContainsKey(objectType))
            {
                return gameObjects[objectType];
            }
            else
            {
                Console.WriteLine("Object of type required doesn't exists in the factory");
                return null;
            }
        }
    }
}
