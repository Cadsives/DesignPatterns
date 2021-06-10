using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Structural.Decorator.Decorator2
{
    class PlainPizza : Pizza
    {
        public string GetDescription()
        {
            return "Thin dough";
        }
        public double GetCost()
        {
            Console.WriteLine("Cost of Dough: " + 4.00);

            return 4.00;
        }
    }
}
