using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.AbstractFactory.AbstractFactory1
{
    class UFOEnemyShipBuilding : EnemyShipBuilding
    {
        protected override EnemyShip MakeEnemyShip(string typeOfShip)
        {
            EnemyShip theEnemyShip = null;

            if (typeOfShip.Equals("UFO"))
            {
                EnemyShipFactory shipPartsFactory = new UFOEnemyShipFactory();
                theEnemyShip = new UFOEnemyShip(shipPartsFactory);
                theEnemyShip.SetName("UFO Grunt Ship");
            } 
            else if(typeOfShip.Equals("UFO BOSS"))
            {
                EnemyShipFactory shipPartsFactory = new UFOBossEnemyShipFactory();
                theEnemyShip = new UFOBossEnemyShip(shipPartsFactory);
                theEnemyShip.SetName("UFO Boss Ship");
            }

            return theEnemyShip;
        } 
    }
}
