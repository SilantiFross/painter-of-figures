using System;
using System.Drawing;

namespace Paint.Classes.Figures
{
    [Serializable]
    public class Line: Shape
    {
        public Point _pointA;
        public Point _pointB;

        public Line()
        { }

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
