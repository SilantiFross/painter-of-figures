using System.Drawing;
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
            var pointOne = new Point((pointA.x + pointB.x) / 2, pointA.y);
            var pointTwo = new Point(pointA.x, pointB.y);
            var pointThree = new Point(pointB.x, pointB.y);
            var triangle = new Triangle(pointOne, pointTwo, pointThree, color);
            StoreFigures.ShapesList.Add(triangle);
            DrawingShapes.Draw(triangle);
        }
    }
}
