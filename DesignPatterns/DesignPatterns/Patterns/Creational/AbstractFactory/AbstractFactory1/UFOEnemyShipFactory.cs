using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.AbstractFactory.AbstractFactory1
{
    class UFOEnemyShipFactory : EnemyShipFactory
    {
        public ESWeapon AddESGun()
        {
            return new ESUFOGun();
        }

        public ESEngine AddESEngine()
        {
            return new ESUFOEngine();
        }
    }
}
