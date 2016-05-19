using System;
using System.Drawing;
using System.Xml.Serialization;

namespace Paint.Classes.Figures
{
    [Serializable]
    public class Rectangle: Shape
    {
        private Point _topLeft;
        private float _height;
        private float _width;

        public Rectangle()
        {
            _topLeft = new Point();
        }

        public Rectangle(Point topLeft, float height, float width, Color color)
        {
            this._topLeft = topLeft;
            this._height = height;
            this._width = width;
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
