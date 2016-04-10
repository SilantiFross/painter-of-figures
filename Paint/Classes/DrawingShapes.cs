using System.Drawing;
using System.Windows.Forms;
using Paint.Classes.Figures;
using Point = Paint.Classes.Figures.Point;
using Rectangle = Paint.Classes.Figures.Rectangle;

namespace Paint.Classes
{
    internal class DrawingShapes
    {
        private static Graphics formGraphics;

        public DrawingShapes(Control pictureBox)
        {
            formGraphics = pictureBox.CreateGraphics();
        }

        public void Draw(Ellipse ellipse)
        {
            var penColor = new Pen(ellipse.Color, 2);

            formGraphics.DrawEllipse(penColor, ellipse.GetTopLeftX, ellipse.GetTopLeftY,
                ellipse.GetWidth, ellipse.GetHeight);
        }

        public void Draw(Line line)
        {
            var penColor = new Pen(line.Color, 2);

            formGraphics.DrawLine(penColor, (PointF)line.GetPointA, (PointF)line.GetPointB);
        }

        public void Draw(Point point)
        {
            var penColor = new Pen(point.Color, 2);

            formGraphics.DrawLine(penColor, point.x, point.y,
                point.x + 1, point.y);
        }

        public void Draw(Rectangle rectangle)
        {
            var penColor = new Pen(rectangle.Color, 2);

            formGraphics.DrawRectangle(penColor, rectangle.GetTopLeftX, rectangle.GetTopLeftY, 
                rectangle.GetHeight, rectangle.GetWidth);
        }

        public void Draw(Triangle triangle)
        {
            var penColor = new Pen(triangle.Color, 2);

            formGraphics.DrawLine(penColor, (PointF)triangle.GetPointA, (PointF)triangle.GetPointB);
            formGraphics.DrawLine(penColor, (PointF)triangle.GetPointB, (PointF)triangle.GetPointC);
            formGraphics.DrawLine(penColor, (PointF)triangle.GetPointC, (PointF)triangle.GetPointA);

        }

    }
}
