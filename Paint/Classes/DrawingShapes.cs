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

            FormGraphics.DrawEllipse(penColor, Main.PointMouseDown.x, Main.PointMouseDown.y,
                Main.PointMouseUp.x - Main.PointMouseDown.x,
                Main.PointMouseUp.y - Main.PointMouseDown.y);
        }

        public static void Draw(Line line)
        { 
            var penColor = new Pen(line.Color);

            FormGraphics.DrawLine(penColor, (PointF)Main.PointMouseDown, (PointF)Main.PointMouseUp);
        }

        public static void Draw(Point point)
        {
            var penColor = new Pen(point.Color);

            FormGraphics.DrawLine(penColor, Main.PointMouseDown.x, Main.PointMouseDown.y,
                Main.PointMouseDown.x + 1, Main.PointMouseDown.y);
        }

        public static void Draw(Rectangle rectangle)
        {
            var penColor = new Pen(rectangle.Color);

            FormGraphics.DrawRectangle(penColor, Main.PointMouseDown.x, Main.PointMouseDown.y,
                Main.PointMouseUp.x - Main.PointMouseDown.x,
                Main.PointMouseUp.y - Main.PointMouseDown.y);
        }

        public static void Draw(Triangle triangle)
        {
            var penColor = new Pen(triangle.Color);

            FormGraphics.DrawLine(penColor, (Main.PointMouseDown.x + Main.PointMouseUp.x) / 2, Main.PointMouseDown.y,
                Main.PointMouseDown.x, Main.PointMouseUp.y);

            FormGraphics.DrawLine(penColor, Main.PointMouseDown.x, Main.PointMouseUp.y,
                Main.PointMouseUp.x, Main.PointMouseUp.y);

            FormGraphics.DrawLine(penColor, Main.PointMouseUp.x, Main.PointMouseUp.y,
                (Main.PointMouseDown.x + Main.PointMouseUp.x) / 2, Main.PointMouseDown.y);

        }
    }
}
