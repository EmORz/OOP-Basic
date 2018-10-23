using System;

namespace ClassBox
{
    public class Box
    {
        private double lenght;
        private double width;
        private double height;

        public Box(double lenght, double width, double height)
        {
            this.Lenght = lenght;
            this.Width = width;
            this.Height = height;                
        }
        public double Height
        {
            get { return height; }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                height = value;
            }
        }

        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                width = value;
            }
        }


        public double Lenght
        {
            get { return lenght; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                lenght = value;
            }
        }

        public double SurfaceArea()
        {
            //2lw + 2lh + 2wh
            return 2 * this.Lenght * this.Width + 2 * this.Lenght * this.Height + 2 * this.Width * this.Height;
        }
        public double LateralSurface()
        {
            //2lh + 2wh
            return 2*this.Lenght*this.Height+2*this.Width*this.Height;
        }
        public double Volume()
        {
            //lwh
            return this.Lenght * this.Width * this.Height;
        }

    }
}
