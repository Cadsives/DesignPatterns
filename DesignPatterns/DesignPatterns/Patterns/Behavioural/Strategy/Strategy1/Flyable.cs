using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Behavioural.Strategy.Strategy1
{
    interface Flyable
    {
        public void Fly();
    }

    class FliesProper : Flyable
    {
        public void Fly()
        {
            Console.WriteLine("I can fly...");
        }
    }

    class DoesNotFly : Flyable
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
