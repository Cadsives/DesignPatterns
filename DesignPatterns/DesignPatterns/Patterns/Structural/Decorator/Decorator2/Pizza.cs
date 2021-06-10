using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Structural.Decorator.Decorator2
{
    interface Pizza
    {
        public abstract string GetDescription();
        public abstract double GetCost();
    }
}
