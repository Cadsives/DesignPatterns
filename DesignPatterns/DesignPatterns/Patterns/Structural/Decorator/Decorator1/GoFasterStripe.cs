using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Structural.Decorator.Decorator1
{
    class GoFasterStripe : AccessoryDecorator
    {
        Car car;

        public GoFasterStripe(Car car)
        {
            SetCar(car);
        }

        public override double Cost()
        {
            return car.Cost() + 100;
        }

        public override string GetDescription()
        {
            return car.GetDescription() + " with a go faster stripe";
        }

        public void SetCar(Car car)
        {
            this.car = car;
        }
    }
}
