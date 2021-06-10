using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.Builder
{
    class Robot : RobotPlan
    {
        private string robotHead;
        private string robotTorso;
        private string robotArms;
        private string robotLegs;
        public void SetRobotHead(string head)
        {
            robotHead = head;
        }
        public string GetRobotHead() { return robotHead; }
        public void SetRobotTorso(string torso)
        {
            robotTorso = torso;
        }
        public string GetRobotTorso() { return robotTorso; }
        public void SetRobotArms(string arms)
        {
            robotArms = arms;
        }
        public string GetRobotArms() { return robotArms; }
        public void SetRobotLegs(string legs)
        {
            robotLegs = legs;
        }
        public string GetRobotLegs() { return robotLegs; }
    }
}
