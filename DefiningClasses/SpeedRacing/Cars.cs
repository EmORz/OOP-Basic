using System;

namespace DefiningClasses
{
    public class Cars
    {

      
        public string model;
        public double fuelAmount;
        public double fuelCost;
        public double traveledDistance;

        public Cars(string model, double fuelAmount, double fuelCost)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelCost = fuelCost;
            this.traveledDistance = 0.0;
        }
        public void Drive(double kilometers)
        {
            var needFuel = kilometers * this.fuelCost;

            if (needFuel>this.fuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
                return;
            }
            this.fuelAmount -= needFuel;
            this.traveledDistance += kilometers;
        }
   


    }
}
