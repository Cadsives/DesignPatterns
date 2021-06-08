using DesignPatterns.Patterns.Behavioural.Command.Command1;
using DesignPatterns.Patterns.Behavioural.Observer.Observer1;
using DesignPatterns.Patterns.Behavioural.Strategy.Strategy1;
using DesignPatterns.Patterns.Creational.Factory.Factory1;
using DesignPatterns.Patterns.Creational.Singleton;
using DesignPatterns.Patterns.Creational.Singleton.Singleton1;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //StrategyDemo1();
            //ObserverDemo1();
            //SingletonDemo1();
            //SingletonDemo2();
            //FactoryDemo1();
            CommandDemo1();
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
        static void SingletonDemo1()
        {
            string output;
            Singleton sigleton1 = Singleton.Instance;
            Singleton sigleton2 = Singleton.Instance;

            if (sigleton1.Equals(sigleton2))
            {
                output = "Only one";
            }
            else
            {
                output = "There're two!!!!!!!!!";
            }

            Console.WriteLine(output);
        }
        static void SingletonDemo2()
        {
            string output;
            Singleton2 sigleton1 = Singleton2.Instance;
            Singleton2 sigleton2 = Singleton2.Instance;

            if (sigleton1.Equals(sigleton2))
            {
                output = "Only one";
            }
            else
            {
                output = "There're two!!!!!!!!!";
            }

            Console.WriteLine(output);
        }     
        static void FactoryDemo1()
        {
            BallGame theGame = new BallGame();
            theGame.PlayGame("White");
        }
        static void CommandDemo1()
        {
            Chef chef = new Chef();

            Waitress theWaitress = new Waitress();

            FoodOrder myStarter = new SoupOrder(chef);
            FoodOrder myMain = new SteakOrder(chef);

            theWaitress.TakeOrder(myStarter);
            theWaitress.TakeOrder(myMain);

            theWaitress.HaveABreak();

            theWaitress.PopIntoKitchen();
        }
    }
}
