using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.Vehicles
{
    public class Semi : Vehicle
    {
        private static int capacitySemi = 10;

        public Semi()
            : base(capacitySemi)
        {
        }
    }
}
