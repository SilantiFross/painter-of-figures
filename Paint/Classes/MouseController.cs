using System.Windows.Forms;
using Point = Paint.Classes.Figures.Point;

namespace Paint.Classes
{
    public static class MouseController
    {
        public static Point PointMouseDown;
        public static Point PointMouseUp;

        public static void GetPointMouseDown(MouseEventArgs e)
        {
            PointMouseDown = new Point(e.X, e.Y);
        }

        public static void GetPointMouseUp(MouseEventArgs e)
        {
            PointMouseUp = new Point(e.X, e.Y);
        }
    }
}
