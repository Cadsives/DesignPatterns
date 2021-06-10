using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Structural.Decorator.Decorator1
{
    abstract class Car
    {
        private string description;

        public Car() {}

        public abstract double Cost();

        public virtual string GetDescription()
        {
            return description;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }
    }
}
