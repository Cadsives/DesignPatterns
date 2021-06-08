using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Behavioural.Command.Command1
{
    class SteakOrder : FoodOrder
    {
        public SteakOrder(Chef chef)
        {
            SetChef(chef);
        }
        public override void Cook()
        {
            chef.PrepareThis("Steak");
        }
    }
}
