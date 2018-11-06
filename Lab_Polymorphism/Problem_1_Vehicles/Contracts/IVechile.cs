using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_1_Vehicles.Contracts
{
    public interface IVechile: IDrive, IRefuel
    {
        double fuelQuantity { get; }
        double fuelConsumation{ get; }
        double DistanceTraveled { get; }



    }
}
