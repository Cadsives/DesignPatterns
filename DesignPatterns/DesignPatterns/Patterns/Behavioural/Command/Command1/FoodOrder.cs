using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Behavioural.Command.Command1
{
    abstract class FoodOrder
    {
        protected Chef chef;

        public abstract void Cook();

        public Chef GetChef()
        {
            return chef;
        }

        public void SetChef(Chef chef)
        {
            this.chef = chef;
        }
    }
}
