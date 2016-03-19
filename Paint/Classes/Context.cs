using System.Windows.Forms;
using Paint.Classes.Figures;
using Point = Paint.Classes.Figures.Point;

namespace Paint.Classes
{
    internal class Context
    {
        public static Shape Shape;
        public static Point PointMouseDown { get; set; }
        public static Point PointMouseUp { get; set; }

        public static void GetPointMouseDown(MouseEventArgs e)
        {
            PointMouseDown = new Point(e.X, e.Y);
        }

        public static void GetPointMouseUp(MouseEventArgs e)
        {
            PointMouseUp = new Point(e.X, e.Y);
            DrawShape();
        }

        public static void GetColorShape(Panel panelColor)
        {
            var colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                panelColor.BackColor = colorDialog.Color;
                Shape.Color = panelColor.BackColor;
            }
        }

        private static void DrawShape()
        {
            dynamic inheritorShape = Shape;
            DrawingShapes.Draw(inheritorShape);
        }

    }
}
