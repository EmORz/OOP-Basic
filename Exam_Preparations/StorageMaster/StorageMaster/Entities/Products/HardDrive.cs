﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.Products
{
    public class HardDrive : Product
    {
        private const double weightHDD = 1.0;

        public HardDrive(double price)
            : base(price, weightHDD)
        {
        }
    }
}
