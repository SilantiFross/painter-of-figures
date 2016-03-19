using System.Drawing;

namespace Paint.Classes.Figures
{
    internal class Ellipse: Shape
    {
        private readonly Point TopLeft;
        private readonly float Width;
        private readonly float Height;

        public Ellipse(Point topLeft, float width, float height, Color color)
        {
            this.TopLeft = topLeft;
            this.Width = width;
            this.Height = height;
            this.Color = color;
        }

        public float GetTopLeftX => TopLeft.x;

        public float GetTopLeftY => TopLeft.y;

        public float GetWidth => Width;

        public float GetHeight => Height;
    }
}
