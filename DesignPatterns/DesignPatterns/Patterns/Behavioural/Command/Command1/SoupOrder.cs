using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Behavioural.Command.Command1
{
    class SoupOrder : FoodOrder
    {
        public SoupOrder(Chef chef)
        {
            SetChef(chef);
        }
        public override void Cook()
        {
            chef.PrepareThis("Soup");
        }
    }
}
