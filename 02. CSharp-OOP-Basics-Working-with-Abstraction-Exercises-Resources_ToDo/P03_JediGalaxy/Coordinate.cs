using System;
using System.Collections.Generic;
using System.Text;

namespace P03_JediGalaxy
{
    public class Coordinate
    {
        private int x;
        private int y;

        public Coordinate(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }


    }
}
