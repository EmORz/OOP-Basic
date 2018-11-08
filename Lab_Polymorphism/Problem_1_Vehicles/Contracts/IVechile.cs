using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_1_Vehicles.Contracts
{
    public interface IVechile: IDrive, IRefuel, IDriveEmpty
    {
        double FuelQuantity { get; }
        double FuelConsumation{ get; }
        double DistanceTraveled { get; }
        double TankCapacity { get; }
    }
}
