using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVSDinosaurs
{
    class Weapon
    {
        // member variables (HAS A) 
        public string weaponType;
        public string weaponPower;
        List<Weapon> weapons;

        // constructors (SPAWNER)
      public Weapon (string weaponType, string weaponPower)
	{
        this.weaponType = weaponType;
        this.weaponPower = weaponPower;
        weapons = new List<Weapon>();   

	}

        // member methods (CAN DO)

    }
}
