using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using EllipseDLL;
using LineDLL;
using PointDLL;
using RectangleDLL;
using ShapeDLL;
using TriangleDLL;

namespace Paint.Classes
{
    [Serializable]
    [XmlInclude(typeof(Ellipse)), XmlInclude(typeof(Line)), XmlInclude(typeof(Point)),
        XmlInclude(typeof(Rectangle)), XmlInclude(typeof(Triangle)), XmlInclude(typeof(Shape))]
    public class StoreFigures
    {
        public List<Shape> ShapesList = new List<Shape>();

        public StoreFigures()
        { }
    }
}
