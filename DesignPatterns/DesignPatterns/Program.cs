using DesignPatterns.Patterns.Behavioural.Observer.Observer1;
using DesignPatterns.Patterns.Behavioural.Strategy.Strategy1;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //StrategyDemo1();
            ObserverDemo1();
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
        static void ObserverDemo1()
        {
            Lecturer john = new Lecturer("John");
            Student lee = new Student("Lee");
            Student Craig = new Student("Craig");

            john.RegisterObserver(lee);
            john.RegisterObserver(Craig);

            john.News = "Free Beer Tomorrow";
            john.NotifyObservers();

            john.RemoveObserver(lee);

            john.News = "Beer Cancelled";
            john.NotifyObservers();
        }
    }
}
