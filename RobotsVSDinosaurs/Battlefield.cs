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
        public int dinosaurScore;
        public Fleet fleet;
        public Herd herd;

        // constructors (SPAWNER)
        public Battlefield()
        {
            robotsScore = 0;
            dinosaurScore = 0;
            fleet = new Fleet();
            herd = new Herd();

        }

        // member methods (CAN DO)

        // Orchestrate your game logic
        // your dinosaurs will attack robots and robots will attack dinosaurs
        // the game will end when?

        public void RunGame()
        {

            // while herd health is not empty and robot health is not empty, continue playing the game
            // robot attacks a dinosaur
            // then a dinosaur attacks
            // when all dinosaurs OR all robots have empty health, declare the winner

            // while robotScore OR dinosaurScore is not EQUAL to 3

            //while (robotsScore != 3 || dinosaurScore != 3)
            //{
            
            //}
                for (int i = 0; i < herd.dinosaurObjects.Count; i++)
                {
                    fleet.robotObjects[i].RobotAttack(herd.dinosaurObjects[i]);
                    if (herd.dinosaurObjects[i].dinosaurHealth <= 0)
                    {
                        Console.WriteLine("Robot won!");
                        robotsScore++;
                    }
                    else if (fleet.robotObjects[i].robotHealth <= 0)
                    {
                        Console.WriteLine("Dinosaur won!");
                        dinosaurScore++;

                        
                        // end the battle 

                    }
                        DisplayWinner();
                        Console.ReadLine();

                }

        }
        public void DisplayWinner()
        {
            if (dinosaurScore == 3)

            {
                Console.WriteLine("Dinosaurs are the winner!!!");
            }

            else if (robotsScore == 3)
            {
                Console.WriteLine("Robots are the winnner!!!");
            }

            else
            {
                Console.WriteLine("Winner has not been determined yet");
            }

        }

            public void CheckDinosaurHealth()
            {
            

            }

            public void CheckRobotHealth()
            {
        

            }



        }

    }


            




      

        

       
