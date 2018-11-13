using System;
using System.Collections.Generic;
using System.Text;
using StorageMaster.Entities.Vehicles;

namespace StorageMaster.Entities.Storages
{
    public class DistributionCenter : Storage
    {
        private const int capacityDC = 2;
        private const int garageSlotsDC = 5;
        private static Vehicle[] vehiclesDC =
        {
            new Van(),
            new Van(),
            new Van()
        };

        public DistributionCenter(string name)
            : base(name, capacityDC, garageSlotsDC, vehiclesDC)
        {
        }
    }
}
