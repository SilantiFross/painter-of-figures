using System.Drawing;
using System.Windows.Forms;
using Paint.Classes.Figures;
using Point = Paint.Classes.Figures.Point;
using Rectangle = Paint.Classes.Figures.Rectangle;

namespace Paint.Classes
{
    internal class Context
    {
        public static Shape Shape;
        public static Point PointMouseDown { get; set; }
        public static Point PointMouseUp { get; set; }
        public static int IdShapes;
        private static Color colorShape;

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
                colorShape = panelColor.BackColor;
            }
        }

        private static void GetIdShapes()
        {
            switch (IdShapes)
            {
                case 0:
                    Shape = new Point(PointMouseDown.x, PointMouseDown.y);
                    break;
                case 1:
                    var pointCenter = new Point((PointMouseDown.x + PointMouseUp.x) / 2,
                        (PointMouseDown.y + PointMouseUp.y) / 2);
                    Shape = new Ellipse(pointCenter, PointMouseUp.x - pointCenter.x, PointMouseUp.y - pointCenter.y, colorShape);
                    break;
                case 2:
                    var pointA = new Point(PointMouseDown.x, PointMouseDown.y);
                    var pointB = new Point(PointMouseUp.x, PointMouseUp.y);
                    Shape = new Line(pointA, pointB, colorShape);
                    break;
                case 3:
                    pointA = new Point((PointMouseDown.x + PointMouseUp.x) / 2, PointMouseDown.y);
                    pointB = new Point(PointMouseDown.x, PointMouseUp.y);
                    var pointC = new Point(PointMouseUp.x, PointMouseUp.y);
                    Shape = new Triangle(pointA, pointB, pointC, colorShape);
                    break;
                case 4:
                    var pointTopLeft = new Point(PointMouseDown.x, PointMouseDown.y);
                    Shape = new Rectangle(pointTopLeft, )

            }
        }

        private static void DrawShape()
        {
            dynamic inheritorShape = Shape;
            DrawingShapes.Draw(inheritorShape);
        }

    }
}
