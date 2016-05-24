using System;
using System.Drawing;
using System.Xml.Serialization;

namespace Paint.Classes.Figures
{
    [Serializable]
    public class Ellipse: Shape
    {
        private Point _topLeft;
        private float _width;
        private float _height;

        public Ellipse()
        {
            _topLeft = new Point();
        }

        public Ellipse(Point topLeft, float width, float height, Color color)
        {
            this._topLeft = topLeft;
            this._width = width;
            this._height = height;
            this.Color = color;
        }

        [XmlElement("x")]
        public float GetTopLeftX
        {
            get { return _topLeft.X; }
            set { _topLeft.X = value; }
        }

        [XmlElement("y")]
        public float GetTopLeftY
        {
            get { return _topLeft.Y; }
            set { _topLeft.Y = value; }
        }

        [XmlElement("_width")]
        public float GetWidth
        {
            get { return _width; }
            set { _width = value; }
        }

        [XmlElement("_height")]
        public float GetHeight
        {
            get { return _height; }
            set { _height = value; }
        }
    }
}
