using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Paint.Classes.Figures;
using Point = Paint.Classes.Figures.Point;
using Rectangle = Paint.Classes.Figures.Rectangle;

namespace Paint.Classes
{
    public class CreatorShapes
    {

        public Point CreatePoint(Point pointA, Color color)
        {
            var point = new Point(pointA.x, pointA.y) {Color = color};

            return point;
        }

        public Line CreateLine(Point pointA, Point pointB, Color color)
        {
            var line = new Line(pointA, pointB, color);

            return line;
        }

        public Rectangle CreateRectangle(Point pointA, Point pointB, Color color)
        {
            var rectangle = new Rectangle(pointA, pointB.x - pointA.x, pointB.y - pointA.y, color);

            return rectangle;
        }

        public Ellipse CreateEllipse(Point pointA, Point pointB, Color color)
        {
            var ellipse = new Ellipse(pointA, pointB.x - pointA.x, pointB.y - pointA.y, color);

            return ellipse;
        }

        public Triangle CreateTriangle(Point pointA, Point pointB, Color color)
        {
            var pointOfTriangle = CreatePointsForTriangle(pointA, pointB);
            var triangle = new Triangle(pointOfTriangle[0], pointOfTriangle[1], pointOfTriangle[2], color);

            return triangle;
        }

        private List<Point> CreatePointsForTriangle(Point pointA, Point pointB)
        {
            var pointOne = new Point((pointA.x + pointB.x) / 2, pointA.y);
            var pointTwo = new Point(pointA.x, pointB.y);
            var pointThree = new Point(pointB.x, pointB.y);

            return new List<Point>()
            {
                pointOne, pointTwo, pointThree
            };
        }

        public void SetColorShape(Panel panelColor)
        {
            var colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                panelColor.BackColor = colorDialog.Color;
            }
        }

    }
}
