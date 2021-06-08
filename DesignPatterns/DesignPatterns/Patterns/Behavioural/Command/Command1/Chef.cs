using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Behavioural.Command.Command1
{
    class Chef
    {
        public void PrepareThis(string food)
        {
            Console.WriteLine("I'm cooking " + food);
        }
    }
}
