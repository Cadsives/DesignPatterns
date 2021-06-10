using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Structural.Decorator.Decorator2
{
    class Mozzarella : ToppingDecorator
    {
        public Mozzarella(Pizza decoratedPizza) : base(decoratedPizza)
        {
            Console.WriteLine("Adding Dough");

            Console.WriteLine("Adding Mozarella Cheese");
        }

        public override string GetDescription()
        {
            return thePizza.GetDescription() + ", Mozarella";
        }

        public override double GetCost()
        {
            Console.WriteLine("Cost of Mozarella Cheese: " + .50);

            return thePizza.GetCost() + .50;
        }
    }
}
