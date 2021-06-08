using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPatterns.Patterns.Behavioural.Command.Command1
{
    class Waitress
    {
        private List<FoodOrder> theOrders = new List<FoodOrder>();

        public void TakeOrder(FoodOrder theOrder)
        {
            theOrders.Add(theOrder);
        }

        public void PopIntoKitchen()
        {
            foreach(FoodOrder order in theOrders)
            {
                order.Cook();
            }
        }

        public void HaveABreak()
        {
            Console.WriteLine("I'm out the back having a break");

            try
            {
                Thread.Sleep(5000);
            }
            catch(ThreadInterruptedException e)
            {
                Console.WriteLine(e.StackTrace);
            }

            Console.WriteLine("I'm back");
        }
    }
}
