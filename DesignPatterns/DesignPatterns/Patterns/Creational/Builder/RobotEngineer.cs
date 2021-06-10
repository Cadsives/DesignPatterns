using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.Builder
{
    class RobotEngineer
    {
        private RobotBuilder robotBuilder;
        public RobotEngineer(RobotBuilder robotBuilder)
        {
            this.robotBuilder = robotBuilder;
        }
        public Robot GetRobot()
        {
            return robotBuilder.GetRobot();
        }
        public void MakeRobot()
        {
            robotBuilder.BuildRobotHead();
            robotBuilder.BuildRobotTorso();
            robotBuilder.BuildRobotArms();
            robotBuilder.BuildRobotLegs();
        }
    }
}
