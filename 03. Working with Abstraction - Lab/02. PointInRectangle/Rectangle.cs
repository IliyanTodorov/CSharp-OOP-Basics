using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace _02._PointInRectangle
{
    public class Rectangle
    {
        private Point topLeft;
        private Point bottomRight;

        public Point TopLeft
        {
            get { return topLeft; }
            set { topLeft = value; }
        }

        public Point BottomRight
        {
            get { return bottomRight; }
            set { bottomRight = value; }
        }


        public bool Contains(Point point)
        {
            bool isInHorizontal =
                TopLeft.PointX <= point.PointX &&
                BottomRight.PointX >= point.PointX;

            bool isInVertical =
                TopLeft.PointY <= point.PointY &&
                BottomRight.PointY >= point.PointY;

            bool isInside = isInHorizontal && isInHorizontal;

            return isInside;
        }
    }
}
