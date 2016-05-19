using System;
using System.Drawing;

namespace Paint.Classes.Figures
{
    [Serializable]
    public class Point: Shape
    {
        public float X;
        public float Y;

        public Point()
        { }

        public Point(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        public static explicit operator PointF(Point v)
        {
            return new PointF(v.X, v.Y);
        }
    }
}
