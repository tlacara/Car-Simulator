using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSimulator
{
    public class Highway
    {
        static void Main(string[] args)
        {
            int fleetNumberPerType = 25;
            int dt = 1;

            //Step 1: implement fleets of arrays/lists per vehicle type
            // and compute states

            Car.Tesla[] myTeslas = new Car.Tesla[fleetNumberPerType].Select(x => new Car.Tesla("Tesla", 1500, 1000, 0.51)).ToArray();
            Car.Prius[] myPriuses = new Car.Prius[fleetNumberPerType].Select(x => new Car.Prius("Prius", 1000, 750, 0.43)).ToArray();
            Car.Mazda[] myMazdas = new Car.Mazda[fleetNumberPerType].Select(x => new Car.Mazda("Mazda 3",1300,900,0.5)).ToArray();
            Car.Herbie[] myHerbies = new Car.Herbie[fleetNumberPerType].Select(x => new Car.Herbie("Herbie",1100,2000,0.3)).ToArray();
             

            for (int i = 0; i < fleetNumberPerType; i++)
            {
                //COMPUTE UPDATED STATE HERE
                //This section is commented out so the program wont print out all the states. Wasn't sure what the exact
                //specifications were.

                //myTeslas[i].drive(dt);
                //myPriuses[i].drive(dt);
                //myMazdas[i].drive(dt);
                //myHerbies[i].drive(dt);

            }

            //Step 2: implement all the fleet in one list and compute states

            var myCars = new List<Car>();

            for (int i = 0; i < fleetNumberPerType; i++)
            {
                //Adding each car type to a list
                myCars.Add(new Car.Tesla("Tesla", 1500, 1000, 0.51));
                myCars.Add(new Car.Prius("Prius", 1000, 750, 0.43));
                myCars.Add(new Car.Mazda("Mazda 3", 1300, 900, 0.5));
                myCars.Add(new Car.Herbie("Herbie", 1100, 2000, 0.3));

            }

            // loop through the time and list to drive all the vehicles

            for (double t = 0; t < 60; t += dt)
            {
                for (int i = 0; i < fleetNumberPerType; i++)
                {
                    // Drive myCars list and Display the cars states acceleration, speed, position, etc

                    Console.Write("time: {0},", t);
                    myCars[i].drive(dt);

                }

            }

        }

    }
}
