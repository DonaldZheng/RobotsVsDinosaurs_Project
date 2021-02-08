using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVSDinosaurs
{
    class Herd
    {
        // member variables (HAS A) 
        List<Dinosaur> dinosaurObjects;

        // constructors (SPAWNER)
        public Herd ()
	    {
            Dinosaur dinosaurOne = new Dinosaur("T-Rex", 100, 100, 50);
            Dinosaur dinosaurTwo = new Dinosaur("Raptor", 100, 100, 50);
            Dinosaur dinosaurThree = new Dinosaur("Tall", 100, 100, 50);
            dinosaurObjects.Add(dinosaurOne);
            dinosaurObjects.Add(dinosaurTwo);
            dinosaurObjects.Add(dinosaurThree);
           
	    }

        // member methods (CAN DO)

    }
}
