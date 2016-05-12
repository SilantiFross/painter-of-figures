using System;
using System.Drawing;

namespace Paint.Classes.Figures
{
    [Serializable]
    public class Triangle: Shape
    {
        public Point _pointA;
        public Point _pointB;
        public Point _pointC;

        public Triangle()
        { }

        public Triangle(Point pointA, Point pointB, Point pointC, Color color)
        {
            this._pointA = pointA;
            this._pointB = pointB;
            this._pointC = pointC;
            this.Color = color;
        }

        public Point GetPointA => _pointA;

        public Point GetPointB => _pointB;

        public Point GetPointC => _pointC;
    }
}
