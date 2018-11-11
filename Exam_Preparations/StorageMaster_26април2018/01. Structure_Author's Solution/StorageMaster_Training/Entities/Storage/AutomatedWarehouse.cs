using System;
using System.Collections.Generic;
using System.Text;
using StorageMaster_Training.Entities.Vechicles;

namespace StorageMaster_Training.Entities.Storage
{
    public class AutomatedWarehouse : Storage
    {
        private static readonly Vehicle[] defaultVehicle =
        {
            new Truck()
        };
        public AutomatedWarehouse(string name)
            : base(name, capacity: 1, garageSlots: 2, vehicles: defaultVehicle)
        {
        }
    }
}
