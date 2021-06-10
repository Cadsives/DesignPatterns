using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.Builder
{
    class OldRobotBuilder : RobotBuilder
    {
        private Robot robot;
        public OldRobotBuilder()
        {
            robot = new Robot();
        }
        public void BuildRobotHead()
        {
            robot.SetRobotHead("Tin Head");
        }
        public void BuildRobotTorso()
        {
            robot.SetRobotTorso("Tin Torso");
        }
        public void BuildRobotArms()
        {
            robot.SetRobotArms("Blowtorch Arms"); 
        }
        public void BuildRobotLegs()
        {
            robot.SetRobotLegs("Roller Skates");
        }
        public Robot GetRobot()
        {
            return robot;
        }
    }
}
