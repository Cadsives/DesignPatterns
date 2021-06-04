using DesignPatterns.Patterns.Behavioural.Strategy.Strategy1;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategyDemo1();
            Console.ReadLine();
        }

        static void StrategyDemo1()
        {
            Duck mallardDuck = new MallardDuck();
            Duck plasticDuck = new PlasticDuck();

            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();

            plasticDuck.PerformFly();
            plasticDuck.PerformQuack();

            plasticDuck.SetFlyBehaviour(new FliesProper());

            plasticDuck.PerformFly();
        }
    }
}
