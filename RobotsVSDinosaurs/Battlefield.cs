using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVSDinosaurs
{
    class Battlefield
    {
        // member variables (HAS A) 

        // constructors (SPAWNER)
           


        // member methods (CAN DO)


        

          

        public void DisplayWinner()
       { 
            if (dinosaurOne <= 0 && dinosaurTwo <= 0 && dinosaurThree <=0)
            {
                Console.WriteLine("Robots Wins");
            }        
            else if (robotOne<= 0 && robotTwo <= 0 && robotThree <=0) 
            {
                Console.WriteLine( "Dinosaur Wins");
            }
            else 
            {
                Console.WriteLine("Winner has not been determined yet");
            }
                    
        }
        
    }
}
