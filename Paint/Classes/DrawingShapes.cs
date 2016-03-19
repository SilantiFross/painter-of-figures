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

            FormGraphics.DrawEllipse(penColor, Context.PointMouseDown.x, Context.PointMouseDown.y,
                Context.PointMouseUp.x - Context.PointMouseDown.x,
                Context.PointMouseUp.y - Context.PointMouseDown.y);
        }

        public static void Draw(Line line)
        { 
            var penColor = new Pen(line.Color);

            FormGraphics.DrawLine(penColor, (PointF)Context.PointMouseDown, (PointF)Context.PointMouseUp);
        }

        public static void Draw(Point point)
        {
            var penColor = new Pen(point.Color);

            FormGraphics.DrawLine(penColor, Context.PointMouseDown.x, Context.PointMouseDown.y,
                Context.PointMouseDown.x + 1, Context.PointMouseDown.y);
        }

        public static void Draw(Rectangle rectangle)
        {
            var penColor = new Pen(rectangle.Color);

            FormGraphics.DrawRectangle(penColor, Context.PointMouseDown.x, Context.PointMouseDown.y,
                Context.PointMouseUp.x - Context.PointMouseDown.x,
                Context.PointMouseUp.y - Context.PointMouseDown.y);
        }

        public static void Draw(Triangle triangle)
        {
            var penColor = new Pen(triangle.Color);

            FormGraphics.DrawLine(penColor, (Context.PointMouseDown.x + Context.PointMouseUp.x) / 2, Context.PointMouseDown.y,
                Context.PointMouseDown.x, Context.PointMouseUp.y);

            FormGraphics.DrawLine(penColor, Context.PointMouseDown.x, Context.PointMouseUp.y,
                Context.PointMouseUp.x, Context.PointMouseUp.y);

            FormGraphics.DrawLine(penColor, Context.PointMouseUp.x, Context.PointMouseUp.y,
                (Context.PointMouseDown.x + Context.PointMouseUp.x) / 2, Context.PointMouseDown.y);

        }
    }
}
