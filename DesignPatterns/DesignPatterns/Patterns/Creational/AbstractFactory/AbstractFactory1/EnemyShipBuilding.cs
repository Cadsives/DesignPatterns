using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.AbstractFactory.AbstractFactory1
{
    abstract class EnemyShipBuilding
    {
        protected abstract EnemyShip MakeEnemyShip(string typeOfShip);

        public EnemyShip OrderTheShip(string typeOfShip)
        {
            EnemyShip theEnemyShip = MakeEnemyShip(typeOfShip);

            theEnemyShip.MakeShip();
            theEnemyShip.DisplayEnemyShip();
            theEnemyShip.FollowHeroShip();
            theEnemyShip.EnemyShipShoots();

            return theEnemyShip;
        }
    }
}
