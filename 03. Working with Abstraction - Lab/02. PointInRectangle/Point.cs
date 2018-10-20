using System;
using System.Collections.Generic;
using System.Text;

namespace _02._PointInRectangle
{
    public class Point
    {
        private int pointX;
        private int pointY;

        public int PointX
        {
            get { return pointX; }
            set { pointX = value; }
        }

        public int PointY
        {
            get { return pointY; }
            set { pointY = value; }
        }

        public Point(int x, int y)
        {
            this.PointX = x;
            this.PointY = y;
        }
    }
}
