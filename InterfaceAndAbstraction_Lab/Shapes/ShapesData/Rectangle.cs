﻿using System;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        private int width;
        private int height;

        public Rectangle(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }

        public int Height
        {
            get { return height; }
            private set { height = value; }
        }
        public int Width
        {
            get { return width; }
            private set { width = value; }
        }

        public void Draw()
        {
            this.DrawLine(this.Width, '*', '*');
            for (int i = 1; i < this.Height-1; i++)
            {
                this.DrawLine(this.Width, '*', ' ');
            }
            this.DrawLine(this.Width, '*', '*');

        }

        private void DrawLine(int width, char end, char mid)
        {
            Console.Write(end);
            for (int i = 1; i < width-1; i++)
            {
                Console.Write(mid);
            }
            Console.WriteLine(end);

        }
    }
}
