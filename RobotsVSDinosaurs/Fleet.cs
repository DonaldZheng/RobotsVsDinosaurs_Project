using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVSDinosaurs
{
    class Fleet
    {
        // member variables (HAS A) 
        public List<Robot> robotObjects;

        // constructors (SPAWNER)

        public Fleet()
        {
            robotObjects = new List<Robot>();
            Robot robotOne = new Robot("Donald", 100, 100, "Sword", 100);
            Robot robotTwo = new Robot("John", 100, 100, "Fist", 100);
            Robot robotThree = new Robot("Andy", 100, 100, "Gun", 100);
            robotObjects.Add(robotOne);
            robotObjects.Add(robotTwo);
            robotObjects.Add(robotThree);
        }


        // member methods (CAN DO)

    }
}
