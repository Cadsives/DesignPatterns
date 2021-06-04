using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Behavioural.Strategy.Strategy1
{
    interface Quackable
    {
        public void Quack();
    }

    public class Squeek : Quackable 
    {
        public void Quack()
        {
            Console.WriteLine("Squeek...");
        }
    }

    public class MuteQuack : Quackable
    {
        public void Quack()
        {
            Console.WriteLine("Silence");
        }
    }


}
