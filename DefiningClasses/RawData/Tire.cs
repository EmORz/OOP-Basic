using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Tire
    {
        public int tireAge;
        public double tirePresure;

        public Tire(int tireAge, double tirePresure)
        {
            this.tireAge = tireAge;
            this.tirePresure = tirePresure;
        }
    }
}
