using System;
using System.Drawing;

namespace Paint.Classes.Figures
{
    [Serializable]
    public class Ellipse: Shape
    {
        public  Point _topLeft;
        public  float _width;
        public  float _height;

        public Ellipse()
        { }

        public Ellipse(Point topLeft, float width, float height, Color color)
        {
            this._topLeft = topLeft;
            this._width = width;
            this._height = height;
            this.Color = color;
        }

        public float GetTopLeftX => _topLeft.x;

        public float GetTopLeftY => _topLeft.y;

        public float GetWidth => _width;

        public float GetHeight => _height;
    }
}
