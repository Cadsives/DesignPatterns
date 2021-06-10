using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Structural.Decorator.Decorator1
{
    class Fiat500 : Car
    {
        public Fiat500()
        {
            SetDescription("Fiat 500");
        }

        public override double Cost()
        {
            return 10000;
        }
    }
}
