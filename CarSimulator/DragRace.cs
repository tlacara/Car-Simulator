using System;
namespace CarSimulator
{
    public class DragRace
    {
        static void Main(string[] args)
        {

            Car myTesla = new Car("Tesla", 1500, 1000, 0.51);
            Car myPrius = new Car("Prius", 1000, 750, 0.43);
            string winner;

            // drive for 60 seconds with delta time of 1s
            double dt = 1;

            for (double t = 0; t < 60; t += dt)
            {
                // print the time and current state
                Console.WriteLine("time:{0}", t);
               
                myTesla.drive(dt);
                myPrius.drive(dt);

               // print who is in lead
               if(myTesla.getState().position>myPrius.getState().position)

                {
                    Console.WriteLine("Tesla is in the lead");
                }

               //print winner of quarter mile
                else if (myTesla.getState().position > 402.3)
                {
                    winner = "Tesla";
                    Console.WriteLine(winner);
                    break;
                }

                else if(myPrius.getState().position>402.3)
                {
                    winner = "Prius";
                    Console.WriteLine(winner);
                    break;
                }

                else
                {
                    Console.WriteLine("Prius is in the lead");
                }
            }

        }
    }
}
