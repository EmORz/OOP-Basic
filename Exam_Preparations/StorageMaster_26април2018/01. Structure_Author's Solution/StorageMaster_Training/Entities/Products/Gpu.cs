﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster_Training.Entities.Products
{
    public class Gpu : Product
    {
        public Gpu(double price) 
            : base(price, 0.7)
        {
        }
    }
}
