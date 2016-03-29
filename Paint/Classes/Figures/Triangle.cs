using System.Drawing;

namespace Paint.Classes.Figures
{
    public class Triangle: Shape
    {
        private readonly Point _pointA;
        private readonly Point _pointB;
        private readonly Point _pointC;

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
