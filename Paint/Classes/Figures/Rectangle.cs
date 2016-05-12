using System;
using System.Drawing;

namespace Paint.Classes.Figures
{
    [Serializable]
    public class Rectangle: Shape
    {
        public Point _topLeft;
        public float _height;
        public float _width;

        public Rectangle()
        { }

        public Rectangle(Point topLeft, float height, float width, Color color)
        {
            this._topLeft = topLeft;
            this._height = height;
            this._width = width;
            this.Color = color;
        }

        public float GetTopLeftX => _topLeft.x;

        public float GetTopLeftY => _topLeft.y;

        public float GetHeight => _height;

        public float GetWidth => _width;

    }
}
