using System.Drawing;

namespace Paint.Classes.Figures
{
    internal class Point: Shape
    {
        public float x;
        public float y;

        public Point()
        {
            //
        }

        public Point(Color color)
        {
            this.Color = color;
        }

        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
            this.Color = Color.Red;
        }

        public static explicit operator PointF(Point v)
        {
            return new PointF(v.x, v.y);
        }
    }
}
