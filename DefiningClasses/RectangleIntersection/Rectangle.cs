using System;

namespace RectangleIntersection
{
    public class Rectangle
    {

        private string id;
        private double width;
        private double height;
        private double x;
        private double y;

        public Rectangle(string id, double width, double height, double x, double y)
        {
            this.Id = id;
            this.Width = Math.Abs(width);
            this.Height = Math.Abs(height);
            this.X = x;
            this.Y = y;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }


        public double Width
        {
            get { return width; }
            set { width = value; }
        }


        public double Height
        {
            get { return height; }
            set { height = value; }
        }



        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        internal bool Intersect(Rectangle secondRect)
        {
            return secondRect.X + secondRect.width >= this.X &&
                secondRect.X <= this.X + this.width &&
                secondRect.Y >= this.Y - this.height &&
                secondRect.Y - secondRect.height <= this.Y;
        }
    }
}
