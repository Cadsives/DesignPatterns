using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Structural.Decorator.Decorator2
{
    class ToppingDecorator : Pizza
    {
        protected Pizza thePizza;

        public ToppingDecorator(Pizza decoratedPizza)
        {
            thePizza = decoratedPizza;
        }
        public virtual string GetDescription()
        {
            return thePizza.GetDescription();
        }
        public virtual double GetCost()
        {
            return thePizza.GetCost();
        }
    }
}
