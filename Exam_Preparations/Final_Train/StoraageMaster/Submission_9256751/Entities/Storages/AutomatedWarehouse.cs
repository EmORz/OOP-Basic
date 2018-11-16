using System;
using System.Collections.Generic;
using System.Text;
using StorageMaster.Entities.Vehicles;

namespace StorageMaster.Entities.Storages
{
    public class AutomatedWarehouse : Storage
    {
        private const int capacityAW = 1;
        private const int garageSlotsAW = 2;

        private static Vehicle[] vehiclesAW =
        {
            new Truck()
        };

        public AutomatedWarehouse(string name)
            : base(name, capacityAW, garageSlotsAW, vehiclesAW)
        {
        }
    }
}
