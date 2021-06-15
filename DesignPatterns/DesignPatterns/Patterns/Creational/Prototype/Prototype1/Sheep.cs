using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.Prototype.Prototype1
{
    class Sheep : Animal
    {
        public Sheep()
        {
            Console.WriteLine("Sheep is made.");
        }
        public object Clone()
        {
            Console.WriteLine("Sheep is being made.");

            Sheep sheepObject = null;
            
            sheepObject = (Sheep)base.MemberwiseClone();

            return sheepObject;
        }

        public override string ToString()
        {
            return "Dolly is my hero, baaa";
        }
    }
}
