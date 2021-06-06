using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.Factory.Factory1
{
    class BallFactory
    {
        public Ball CreateBall(string colour)
        {
            Ball ball = null;

            if (string.Equals(colour, "white", StringComparison.InvariantCultureIgnoreCase))
            {
                ball = new WhiteBall();
            }
            else if (string.Equals(colour, "black", StringComparison.InvariantCultureIgnoreCase))
            {
                ball = new BlackBall();
            }
            else if (string.Equals(colour, "red", StringComparison.InvariantCultureIgnoreCase))
            {
                ball = new RedBall();
            }

            return ball;
        }
    }
}
