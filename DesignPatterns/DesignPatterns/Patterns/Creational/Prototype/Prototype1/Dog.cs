using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.Prototype.Prototype1
{
    class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("Dog is made");
        }
        public object Clone()
        {
            Console.WriteLine("Dog is being made");

            Dog dogObject = null;

            dogObject = (Dog)base.MemberwiseClone();

            return dogObject;
        }

        public override string ToString()
        {
            return "Woof, woof";
        }
    }
}
