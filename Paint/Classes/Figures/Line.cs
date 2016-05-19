using System;
using System.Drawing;
using System.Xml.Serialization;

namespace Paint.Classes.Figures
{
    [Serializable]
    public class Line: Shape
    {
        private Point _pointA;
        private Point _pointB;

        public Line()
        { }

        public Line(Point pointA, Point pointB, Color color)
        {
            this._pointA = pointA;
            this._pointB = pointB;
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
    }
}
