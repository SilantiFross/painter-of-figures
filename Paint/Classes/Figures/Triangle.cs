using System;
using System.Drawing;
using System.Xml.Serialization;

namespace Paint.Classes.Figures
{
    [Serializable]
    public class Triangle: Shape
    {
        private Point _pointA;
        private Point _pointB;
        private Point _pointC;

        public Triangle()
        { }

        public Triangle(Point pointA, Point pointB, Point pointC, Color color)
        {
            this._pointA = pointA;
            this._pointB = pointB;
            this._pointC = pointC;
            this.Color = color;
        }

        [XmlElement("_pointA")]
        public Point GetPointA
        {
            get { return _pointA; }
            set { _pointA = value; }
        }

        [XmlElement("_pointB")]
        public Point GetPointB
        {
            get { return _pointB; }
            set { _pointB = value; }
        }

        [XmlElement("_pointC")]
        public Point GetPointC
        {
            get { return _pointC; }
            set { _pointC = value; }
        }
    }
}
