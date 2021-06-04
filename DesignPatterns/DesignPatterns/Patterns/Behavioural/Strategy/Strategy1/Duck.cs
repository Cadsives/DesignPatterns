using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Behavioural.Strategy.Strategy1
{
    abstract class Duck
    {
        protected Flyable flyBehaviour;
        protected Quackable quackBehaviour;

        public void PerformFly()
        {
            flyBehaviour.Fly();
        }

        public void PerformQuack()
        {
            quackBehaviour.Quack();
        }

        public Flyable GetFlyBehaviour()
        {
            return flyBehaviour;
        }

        public void SetFlyBehaviour(Flyable flyBehaviour)
        {
            this.flyBehaviour = flyBehaviour;
        }

        public Quackable GetQuackBehaviour()
        {
            return quackBehaviour;
        }

        public void SetQuackBehaviour(Quackable quackBehaviour)
        {
            this.quackBehaviour = quackBehaviour;
        }
    }
}
