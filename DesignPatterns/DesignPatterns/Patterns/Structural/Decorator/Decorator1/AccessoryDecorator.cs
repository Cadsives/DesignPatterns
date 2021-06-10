using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Structural.Decorator.Decorator1
{
    abstract class AccessoryDecorator : Car
    {
        public override abstract double Cost();

        public override abstract string GetDescription();
    }
}
