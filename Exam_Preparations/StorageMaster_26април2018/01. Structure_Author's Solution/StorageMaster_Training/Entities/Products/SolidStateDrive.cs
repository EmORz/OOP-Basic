﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster_Training.Entities.Products
{
    public class SolidStateDrive : Product
    {
        public SolidStateDrive(double price) 
            : base(price, 0.2)
        {
        }
    }
}
