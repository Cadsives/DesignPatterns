using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.AbstractFactory.AbstractFactory1
{
    class UFOEnemyShip : EnemyShip
    {
        EnemyShipFactory shipFactory;

        public UFOEnemyShip(EnemyShipFactory shipFactory)
        {
            this.shipFactory = shipFactory;
        }

        public override void MakeShip()
        {
            Console.WriteLine("Making Enemy Ship " + GetName());

            weapon = shipFactory.AddESGun();
            engine = shipFactory.AddESEngine();
        }
    }
}
