using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Behavioural.Strategy.Strategy1
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            SetFlyBehaviour(new FliesProper());
            SetQuackBehaviour(new Squeek());
        }
    }
}
