using System.Windows.Forms;
using Paint.Classes.Figures;
using Paint.Properties;
using Point = Paint.Classes.Figures.Point;

namespace Paint.Classes
{
    internal static class Main
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
            if (Shape != null)
            {
                PointMouseUp = new Point(e.X, e.Y);
                DrawShape();
            }
            else
            {
                MessageBox.Show(Resources.Main_GetPointMouseUp_Message_Box);
            }
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
