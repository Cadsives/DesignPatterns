using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Behavioural.Strategy.Strategy1
{
    class PlasticDuck : Duck
    {
        public PlasticDuck()
        {
            SetFlyBehaviour(new DoesNotFly());
            SetQuackBehaviour(new MuteQuack());
        }
    }
}
