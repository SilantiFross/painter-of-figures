using System.Drawing;

namespace Paint.Classes.Figures
{
    internal class Line: Shape
    {
        private readonly Point _pointA;
        private readonly Point _pointB;

        public Line()
        {
            //
        }

        public Line(Color color)
        {
            this.Color = color;
        }

        public Line(Point pointA, Point pointB, Color color)
        {
            this._pointA = pointA;
            this._pointB = pointB;
            this.Color = color;
        }

        public Point GetPointA => _pointA;

        public Point GetPointB => _pointB;
    }
}
