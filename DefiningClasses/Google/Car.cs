﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }

        public Car(string model, int speed)
        {
            this.Model = model;
            this.Speed = speed;
        }
        public override string ToString()
        {
            return $"{this.Model} {this.Speed}";
        }


    }
}
