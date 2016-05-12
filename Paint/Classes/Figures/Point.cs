using System;
using System.Drawing;

namespace Paint.Classes.Figures
{
    [Serializable]
    public class Point: Shape
    {
        public float x;
        public float y;

        public Point()
        { }

        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public static explicit operator PointF(Point v)
        {
            return new PointF(v.x, v.y);
        }
    }
}
