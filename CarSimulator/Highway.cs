using System;
using System.Linq;

namespace CarSimulator
{
    public class Highway
    {
        static void Main(string[] args)
        {
            int fleetNumberPerType = 25;
            //Step 1: implement fleets of arrays/lists per vehicle type
            // and compute states
            //TO DO: Projects each element of a sequence into a new form
            Car.Tesla[] myTeslas = new Car.Tesla[fleetNumberPerType].Select(x => new Car.Tesla()).ToArray();
            Car.Prius[] myPriuses = new Car.Prius[fleetNumberPerType].Select(x => new Car.Prius()).ToArray();
            Car.Mazda[] myMazdas = new Car.Mazda[fleetNumberPerType].Select(x => new Car.Mazda()).ToArray();
            Car.Herbie[] myHerbies = new Car.Herbie[fleetNumberPerType].Select(x => new Car.Herbie()).ToArray();

            //Step 2: implement all the fleet in one list and compute states
            Console.WriteLine(myTeslas[0]);

            for (int i = 0; i < fleetNumberPerType; i++)
            {
                // TODO: COMPUTE UPDATED STATE HERE
             

            }



        }

    }
}
