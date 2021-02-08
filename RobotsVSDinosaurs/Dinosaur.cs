using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVSDinosaurs
{
    class Dinosaur
    {
        // member variables (HAS A) 
        public string dinosaurType;
        public double dinosaurHealth;
        public double dinosaurEnergy;
        public double dinosaurAttackPower;
        

        // constructors (SPAWNER)

        // member methods (CAN DO)

        public void DinosaurAttack()
        {

        }

        public void DinosaurLosingHealth(int robotAttackPower, int dinosaurAttackPower)
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
