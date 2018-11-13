using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.Vehicles
{
    public class Van : Vehicle
    {
        private const int capacityVan = 2;

        public Van()
            : base(capacityVan)
        {
        }
    }
}
