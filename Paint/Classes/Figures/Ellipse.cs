using System.Drawing;

namespace Paint.Classes.Figures
{
    internal class Ellipse: Shape
    {
        private readonly Point _topLeft;
        private readonly float _width;
        private readonly float _height;

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
