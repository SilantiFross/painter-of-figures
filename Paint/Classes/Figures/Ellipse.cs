using System.Drawing;

namespace Paint.Classes.Figures
{
    internal class Ellipse: Shape
    {
        private readonly Point _center;
        private readonly float _radiusX;
        private readonly float _radiusY;

        public Ellipse()
        {
            //
        }

        public Ellipse(Color color)
        {
            this.Color = color;
        }

        public Ellipse(Point center, float radiusX, float radiusY, Color color)
        {
            this._center = center;
            this._radiusX = radiusX;
            this._radiusY = radiusY;
            this.Color = color;
        }

        public float GetCenterX => _center.x;

        public float GetCenterY => _center.y;

        public float GetRadiusX => _radiusX;

        public float GetRadiusY => _radiusY;
    }
}
