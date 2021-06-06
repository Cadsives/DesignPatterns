using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.Factory.Factory1
{
    class BallGame
    {
        BallFactory theFactory;

        public BallGame()
        {
            SetTheFactory(new BallFactory());
        }

        public void PlayGame(string colour)
        {
            Ball ball;

            ball = this.theFactory.CreateBall(colour);

            ball.AnnounceWinner();
        }

        public void SetTheFactory(BallFactory theFactory)
        {
            this.theFactory = theFactory;
        }
    }
}
