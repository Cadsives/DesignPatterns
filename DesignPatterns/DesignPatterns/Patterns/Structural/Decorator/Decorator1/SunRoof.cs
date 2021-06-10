using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Structural.Decorator.Decorator1
{
    class SunRoof : AccessoryDecorator
    {
        Car car;

        public SunRoof(Car car)
        {
            SetCar(car);
        }

        public override double Cost()
        {
            return car.Cost() + 500;
        }

        public override string GetDescription()
        {
            return car.GetDescription() + " with a sun roof";
        }

        public void SetCar(Car car)
        {
            this.car = car;
        }
    }
}
