using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.Builder
{
    interface RobotPlan
    {
        public void SetRobotHead(string head);
        public void SetRobotTorso(string torso);
        public void SetRobotArms(string arms);
        public void SetRobotLegs(string legs);
    }
}
