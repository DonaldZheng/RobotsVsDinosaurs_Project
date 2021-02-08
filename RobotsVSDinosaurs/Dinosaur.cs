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
        public Dinosaur (string dinosaurType, double dinosaurHealth, double dinosaurEnergy, double dinosaurAttackPower)
	{
            this.dinosaurType = dinosaurType;
            this.dinosaurHealth = dinosaurHealth;
            this.dinosaurEnergy = dinosaurEnergy;
            this.dinosaurAttackPower = dinosaurAttackPower;
	}
        // member methods (CAN DO)

        public void DinosaurAttack(Robot robot)
        {
          
        }

  

        
    }
}
