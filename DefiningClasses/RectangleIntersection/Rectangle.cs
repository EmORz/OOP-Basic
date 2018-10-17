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
            if (this.X + this.Width < secondRect.X
                || secondRect.X+secondRect.Width<this.X
                ||this.Y + this.Height<secondRect.Y
                ||secondRect.Y+secondRect.Height<this.Y)
            {
                return false;
            }
            return true;
        }
    }
}
