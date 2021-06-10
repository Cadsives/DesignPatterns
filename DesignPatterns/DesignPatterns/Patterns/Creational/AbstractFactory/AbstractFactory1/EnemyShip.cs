using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.AbstractFactory.AbstractFactory1
{
    abstract class EnemyShip
    {
        private string name;

        protected ESWeapon weapon;
        protected ESEngine engine;

        public string GetName() { return name; }
        public void SetName(string theName) { name = theName; }

        public abstract void MakeShip();

        public void FollowHeroShip()
        {
            Console.WriteLine(GetName() + " is following the hero at " + engine);
        }

        public void DisplayEnemyShip()
        {
            Console.WriteLine(GetName() + " is on the screen");
        }

        public void EnemyShipShoots()
        {
            Console.WriteLine(GetName() + " attacks and does " + weapon);
        }

        public string TheString()
        {
            string infoOnShip = "The " + name + " has a top speed of " + engine.TheString() + " and an attack power of " + weapon.TheString();

            return infoOnShip;
        }
    }
}
