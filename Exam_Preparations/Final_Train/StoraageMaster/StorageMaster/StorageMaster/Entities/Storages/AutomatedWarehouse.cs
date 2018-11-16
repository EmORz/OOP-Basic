using System;
using System.Collections.Generic;
using System.Text;
using StorageMaster.Entities.Vehicles;

namespace StorageMaster.Entities.Storages
{
    public class AutomatedWarehouse : Storage
    {
        /*•	AutomatedWarehouse – always has 1 capacity and 2 garage slots
o	Default vehicles: 1 Truck
0*/

        private const int capacity = 1;
        private const int garageSlots = 2;
        private static Vehicle[] vehicles =
        {
            new Truck()
        };
        public AutomatedWarehouse(string name) 
            : base(name, capacity, garageSlots, vehicles)
        {
        }
    }
}
