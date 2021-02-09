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
        public List<Dinosaur> dinosaurObjects;

        // constructors (SPAWNER)
        public Herd ()
	    {
            dinosaurObjects = new List<Dinosaur>();
            Dinosaur dinosaurOne = new Dinosaur("T-Rex", 100, 100, 0);
            Dinosaur dinosaurTwo = new Dinosaur("Raptor", 100, 100, 0);
            Dinosaur dinosaurThree = new Dinosaur("Tall", 100, 100, 0);
            dinosaurObjects.Add(dinosaurOne);
            dinosaurObjects.Add(dinosaurTwo);
            dinosaurObjects.Add(dinosaurThree);
           
	    }

        // member methods (CAN DO)

    }
}
