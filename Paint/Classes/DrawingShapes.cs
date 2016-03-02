using System.Drawing;
using System.Windows.Forms;
using Paint.Classes.Figures;
using Point = Paint.Classes.Figures.Point;
using Rectangle = Paint.Classes.Figures.Rectangle;

namespace Paint.Classes
{
    internal static class DrawingShapes
    {
        private static readonly Form FormForDrawing = Form.ActiveForm;
        private static readonly Graphics FormGraphics = FormForDrawing.CreateGraphics();

        public static void Draw(Ellipse ellipse)
        {
            var penColor = new Pen(ellipse.Color);

            FormGraphics.DrawEllipse(penColor, ellipse.GetCenterX, ellipse.GetCenterY, ellipse.GetRadiusX,
                ellipse.GetRadiusY);
        }

        public static void Draw(Line line)
        { 
            var penColor = new Pen(line.Color);

            FormGraphics.DrawLine(penColor, (PointF)line.GetPointA, (PointF)line.GetPointB);
        }

        public static void Draw(Point point)
        {
            var penColor = new Pen(point.Color);

            FormGraphics.DrawLine(penColor, point.x, point.y, point.x + 1, point.y);
        }

        public static void Draw(Polyline polyline)
        {
            foreach (var line in polyline.lines)
            {
                var penColor = new Pen(line.Color);
                FormGraphics.DrawLine(penColor, (PointF)line.GetPointA, (PointF)line.GetPointB);
            }
        }

        public static void Draw(Rectangle rectangle)
        {
            var penColor = new Pen(rectangle.Color);

            FormGraphics.DrawLine(penColor, rectangle.GetTopLeftX, rectangle.GetTopLeftY,
                rectangle.GetTopLeftX + rectangle.GetWidth, rectangle.GetTopLeftY);

            FormGraphics.DrawLine(penColor, rectangle.GetTopLeftX, rectangle.GetTopLeftY, rectangle.GetTopLeftX,
                rectangle.GetTopLeftY + rectangle.GetHeight);

            FormGraphics.DrawLine(penColor, rectangle.GetTopLeftX + rectangle.GetWidth, rectangle.GetTopLeftY,
                rectangle.GetTopLeftX + rectangle.GetWidth, rectangle.GetTopLeftY + rectangle.GetHeight);

            FormGraphics.DrawLine(penColor, rectangle.GetTopLeftX, rectangle.GetTopLeftY + rectangle.GetWidth,
                rectangle.GetTopLeftX + rectangle.GetWidth, rectangle.GetTopLeftY + rectangle.GetHeight);
        }

        public static void Draw(Triangle triangle)
        {
            var penColor = new Pen(triangle.Color);

            FormGraphics.DrawLine(penColor, (PointF) (triangle.GetPointA), (PointF) (triangle.GetPointB));
            FormGraphics.DrawLine(penColor, (PointF) (triangle.GetPointB), (PointF) (triangle.GetPointC));
            FormGraphics.DrawLine(penColor, (PointF) (triangle.GetPointC), (PointF) (triangle.GetPointA));
        }
    }
}
