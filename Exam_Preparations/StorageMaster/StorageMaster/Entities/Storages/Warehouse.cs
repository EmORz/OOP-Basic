using System;
using System.Collections.Generic;
using System.Text;
using StorageMaster.Entities.Vehicles;

namespace StorageMaster.Entities.Storages
{
    public class Warehouse : Storage
    {
        private const int capacityWarehouse = 10;
        private const int garageSlotsWarehouse = 10;
        private static Vehicle[] vehiclesWarehouse=
        {
            new Semi(),
            new Semi(),
            new Semi()
        };

        //Each type of storage receives a name upon initialization.

        public Warehouse(string name) 
            : base(name, capacityWarehouse, garageSlotsWarehouse, vehiclesWarehouse)
        {
        }
    }
}
