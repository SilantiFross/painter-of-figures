using System.Drawing;

namespace Paint.Classes.Figures
{
    internal class Rectangle: Shape
    {
        private readonly Point _topLeft;
        private readonly float _height;
        private readonly float _width;

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
