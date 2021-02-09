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
        // has a fleet and a herd!
        public int robotsScore;
        public int DinosaurScore;
        public Fleet fleet;
        public Herd herd;

        // constructors (SPAWNER)
          public Battlefield ()
	{
           robotsScore = 0;
           dinosaurScore = 0;
           fleet = new Fleet ();
           herd = new Herd();

	}

        // member methods (CAN DO)

        // Orchestrate your game logic
        // your dinosaurs will attack robots and robots will attack dinosaurs
        // the game will end when?
        
        public double RunGame()
        {
          
            for (int i = 0; i < herd.dinosaurObjects.Count; i++)
			{
                fleet.robotObjects[i].RobotAttack(herd.dinosaurObjects[i]);
                if (herd.dinosaurObjects[i].dinosaurHealth <= 0)
                {
                    Console.WriteLine("Robot won!");
                    return robotsScore++;
                }
                else if (fleet.robotObjects[i].robotHealth <= 0)
                {
                    Console.WriteLine("Dinosaur won!");
                    return dinosaurScore++;

                }
			}
           
            for (int i = 0; i < fleet.robotObjects.Count; i++)
			{
                herd.dinosaurObjects[0].DinosaurAttack(fleet.robotObjects[0])
                if (fleet.robotObjects[i].robotHealth <= 0)
                {
                    Console.WriteLine("Dinosaur won!");
                    return dinosaurScore++;
                }
                else if (herd.dinosaurObjects[i].dinosaurHealth <= 0)
                {
                    Console.WriteLine("Robot Won!");
                }
			}

                

            public void DisplayWinner()
            {
                if (DinosaurScore == 3)
                {
                Console.WriteLine("Dinosaurs' Wins!");

                else if (playerTwoScore == 3)
            {
                Console.WriteLine("Robots' Wins!");
            }    
                else 
                {
                    Console.WriteLine("Winner has not been determined yet");
                }

                }
       }


        }
            
            
        
        }



      

        

        
}
