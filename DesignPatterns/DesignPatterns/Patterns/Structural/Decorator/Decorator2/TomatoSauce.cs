using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Structural.Decorator.Decorator2
{
    class TomatoSauce : ToppingDecorator
    {
        public TomatoSauce(Pizza decoratedPizza) : base(decoratedPizza)
        {
            Console.WriteLine("Adding Tomato Sauce");
        }

        public override string GetDescription()
        {
            return thePizza.GetDescription() + ", Tomato Sauce";
        }

        public override double GetCost()
        {
            Console.WriteLine("Cost of Tomato Sauce: " + .35);

            return thePizza.GetCost() + .35;
        }
    }
}
