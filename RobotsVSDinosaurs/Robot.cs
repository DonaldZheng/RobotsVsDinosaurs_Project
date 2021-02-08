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
       public Robot ()
	{
        robotHealth = 100;
	}

        // member methods (CAN DO)

        public void RobotAttack()
        {
            
        }

        public void RobotLosingHealth(int robotAttackPower, int dinosaurAttackPower)
        {
            if (robotAttackPower > dinosaurAttackPower)
            {
                Console.WriteLine("Dinosaur loses health points");
                

            }

            else if (dinosaurAttackPower > robotAttackPower)
                {
                Console.WriteLine("Robot loses health points");
            }

            else 
            {
                Console.WriteLine("The battle was a draw!");
            }
        }

    }
}
