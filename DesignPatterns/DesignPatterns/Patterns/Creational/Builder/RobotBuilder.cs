using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.Builder
{
    interface RobotBuilder
    {
        public void BuildRobotHead();
        public void BuildRobotTorso();
        public void BuildRobotArms();
        public void BuildRobotLegs();
        public Robot GetRobot();
    }
}
