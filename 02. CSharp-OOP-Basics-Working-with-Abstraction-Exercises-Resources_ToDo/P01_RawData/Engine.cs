﻿namespace P01_RawData
{
    class Engine
    {
        private int speed;

        private int power;

        public Engine(int speed, int power)
        {
            this.speed = speed;
            this.power = power;
        }


        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public int Power
        {
            get { return power; }
            set { power = value; }
        }

    }
}
