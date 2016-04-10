using System.Drawing;
using System.Windows.Forms;
using Paint.Classes.Figures;
using Point = Paint.Classes.Figures.Point;
using Rectangle = Paint.Classes.Figures.Rectangle;

namespace Paint.Classes
{
    internal class DrawingShapes
    {
        private static readonly Form FormForDrawing = Form.ActiveForm;
        private static readonly Graphics FormGraphics = FormForDrawing.CreateGraphics();

        public void Draw(Ellipse ellipse)
        {
            var penColor = new Pen(ellipse.Color);

            FormGraphics.DrawEllipse(penColor, ellipse.GetTopLeftX, ellipse.GetTopLeftY,
                ellipse.GetWidth, ellipse.GetHeight);
        }

        public void Draw(Line line)
        {
            var penColor = new Pen(line.Color);

            FormGraphics.DrawLine(penColor, (PointF)line.GetPointA, (PointF)line.GetPointB);
        }

        public void Draw(Point point)
        {
            var penColor = new Pen(point.Color);

            FormGraphics.DrawLine(penColor, point.x, point.y,
                point.x + 1, point.y);
        }

        public void Draw(Rectangle rectangle)
        {
            var penColor = new Pen(rectangle.Color);

            FormGraphics.DrawRectangle(penColor, rectangle.GetTopLeftX, rectangle.GetTopLeftY, 
                rectangle.GetHeight, rectangle.GetWidth);
        }

        public void Draw(Triangle triangle)
        {
            var penColor = new Pen(triangle.Color);

            FormGraphics.DrawLine(penColor, (PointF)triangle.GetPointA, (PointF)triangle.GetPointB);
            FormGraphics.DrawLine(penColor, (PointF)triangle.GetPointB, (PointF)triangle.GetPointC);
            FormGraphics.DrawLine(penColor, (PointF)triangle.GetPointC, (PointF)triangle.GetPointA);

        }

    }
}
