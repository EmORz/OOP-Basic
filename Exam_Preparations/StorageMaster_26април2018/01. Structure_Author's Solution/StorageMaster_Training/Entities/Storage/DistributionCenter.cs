using System;
using System.Collections.Generic;
using System.Text;
using StorageMaster_Training.Entities.Vechicles;

namespace StorageMaster_Training.Entities.Storage
{
    public class DistributionCenter : Storage
    {
        private static readonly Vehicle[] defaultVehicle =
        {
            new Van(), new Van(), new Van()
        };
        public DistributionCenter(string name)
            : base(name, capacity: 1, garageSlots: 5, vehicles: defaultVehicle)
        {
        }
    }
}
