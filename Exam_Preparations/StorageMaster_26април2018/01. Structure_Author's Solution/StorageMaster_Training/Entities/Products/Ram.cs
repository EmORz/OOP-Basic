using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster_Training.Entities.Products
{
    public class Ram : Product
    {
        public Ram(double price)
            : base(price, 0.1)
        {
        }
    }
}
