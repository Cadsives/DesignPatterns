using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Structural.Decorator.Decorator1
{
    class FiatPunto : Car
    {
        public FiatPunto()
        {
            SetDescription("Fiat Punto");
        }

        public override double Cost()
        {
            return 15000;
        }
    }
}
