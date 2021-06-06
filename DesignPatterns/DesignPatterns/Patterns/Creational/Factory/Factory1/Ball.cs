using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.Factory.Factory1
{
    abstract class Ball 
    {
        protected string colour;

        public void AnnounceWinner()
        {
            Console.WriteLine("The winner is " + GetColour());
        }

        public string GetColour()
        {
            return colour;
        }

        public void SetColour(string colour)
        {
            this.colour = colour;
        }
    }
}
