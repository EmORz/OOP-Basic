namespace PointInRectangle
{
    class Rectangle
    {
        public Point topLeft;
        public Point bottomRight;

        public Rectangle(Point left, Point right)
        {
            this.topLeft = left;
            this.bottomRight = right;
        }
        public bool Contains(Point point)
        {
            bool isInHorizontal = this.topLeft.X <= point.X && this.bottomRight.X >= point.X;
            bool isVertical     = this.topLeft.Y <= point.Y && this.bottomRight.Y >= point.Y;
            return isInHorizontal && isVertical;
        }
    }
}
