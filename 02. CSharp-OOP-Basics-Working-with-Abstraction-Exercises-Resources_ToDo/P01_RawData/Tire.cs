namespace P01_RawData
{
    class Tire
    {
        private double pressure;
        private int age;

        public Tire(double pressure, int age)
        {
            this.Pessure = pressure;
            this.Age = age;
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public double Pessure
        {
            get { return pressure; }
            set { pressure = value; }
        }

    }
}
