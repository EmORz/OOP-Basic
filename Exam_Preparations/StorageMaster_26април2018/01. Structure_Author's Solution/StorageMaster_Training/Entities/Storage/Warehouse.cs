using System;
using System.Collections.Generic;
using System.Text;
using StorageMaster_Training.Entities.Vechicles;

namespace StorageMaster_Training.Entities.Storage
{
    public class Warehouse : Storage
    {
        private static readonly Vehicle[] defaultVehicle =
        {
            new Semi(), new Semi(), new Semi()
        };
        public Warehouse(string name) 
            : base(name, capacity: 10, garageSlots: 10, vehicles: defaultVehicle)
        {
        }
    }
}
