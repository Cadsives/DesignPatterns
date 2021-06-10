using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.AbstractFactory.AbstractFactory1
{
    class UFOBossEnemyShipFactory : EnemyShipFactory
    {
        public ESWeapon AddESGun()
        {
            return new ESUFOBossGun();
        }

        public ESEngine AddESEngine()
        {
            return new ESUFOBossEngine();
        }
    }
}
