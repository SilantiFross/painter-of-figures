using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Paint.Classes.Figures;
using Point = Paint.Classes.Figures.Point;
using Rectangle = Paint.Classes.Figures.Rectangle;

namespace Paint.Classes
{
    public static class CreatorShapes
    {

        public static void CreatePoint(Point pointA, Color color)
        {
            var point = new Point(pointA.x, pointA.y) {Color = color};
            StoreFigures.ShapesList.Add(point);
            DrawingShapes.Draw(point);
        }

        public static void CreateLine(Point pointA, Point pointB, Color color)
        {
            var line = new Line(pointA, pointB, color);
            StoreFigures.ShapesList.Add(line);
            DrawingShapes.Draw(line);
        }

        public static void CreateRectangle(Point pointA, Point pointB, Color color)
        {
            var rectangle = new Rectangle(pointA, pointB.x - pointA.x, pointB.y - pointA.y, color);
            StoreFigures.ShapesList.Add(rectangle);
            DrawingShapes.Draw(rectangle);
        }

        public static void CreateEllipse(Point pointA, Point pointB, Color color)
        {
            var ellipse = new Ellipse(pointA, pointB.x - pointA.x, pointB.y - pointA.y, color);
            StoreFigures.ShapesList.Add(ellipse);
            DrawingShapes.Draw(ellipse);
        }

        public static void CreateTriangle(Point pointA, Point pointB, Color color)
        {
            var pointOfTriangle = CreatePointsForTriangle(pointA, pointB);
            var triangle = new Triangle(pointOfTriangle[0], pointOfTriangle[1], pointOfTriangle[2], color);
            StoreFigures.ShapesList.Add(triangle);
            DrawingShapes.Draw(triangle);
        }

        private static List<Point> CreatePointsForTriangle(Point pointA, Point pointB)
        {
            var pointOne = new Point((pointA.x + pointB.x) / 2, pointA.y);
            var pointTwo = new Point(pointA.x, pointB.y);
            var pointThree = new Point(pointB.x, pointB.y);

            return new List<Point>()
            {
                pointOne, pointTwo, pointThree
            };
        }

        public static void SetColorShape(Panel panelColor)
        {
            var colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                panelColor.BackColor = colorDialog.Color;
            }
        }

    }
}
