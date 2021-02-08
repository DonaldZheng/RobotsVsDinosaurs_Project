using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVSDinosaurs
{
    class Robot
    {
        // member variables (HAS A) 
        public string robotName;
        public double robotHealth;
        public double robotPowerLevel;
        public string robotWeaponType;
        public double robotAttackPower;

        // constructors (SPAWNER)
       public Robot (string robotName, double robotHealth, double robotPowerLevel, string robotWeaponType, double robotAttackPower)
	    {
            this.robotName = robotName;
            this.robotHealth = robotHealth;
            this.robotPowerLevel = robotPowerLevel;
            this.robotWeaponType = robotWeaponType;
            this.robotAttackPower = robotAttackPower;
	    }

        // member methods (CAN DO)

       public void RobotAttack(Dinosaur dinosaur)
        {
           
        }

      
        }

    }
}
