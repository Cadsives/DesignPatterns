using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.AbstractFactory.AbstractFactory1
{
    interface EnemyShipFactory
    {
        public ESWeapon AddESGun();
        public ESEngine AddESEngine();
    }
}
