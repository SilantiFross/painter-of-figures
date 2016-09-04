using System.Windows.Forms;
using Point = Paint.Classes.Figures.Point;

namespace Paint.Classes
{
    public class MouseController
    {
        public Point PointMouseDown;
        public Point PointMouseUp;

        public MouseController()
        {
            this.PointMouseDown = new Point(0, 0);
            this.PointMouseUp = new Point(0, 0);
        }

        public void GetPointMouseDown(MouseEventArgs e)
        {
            PointMouseDown.X = e.X;
            PointMouseDown.Y = e.Y;
        }

        public void GetPointMouseUp(MouseEventArgs e)
        {
            PointMouseUp.X = e.X;
            PointMouseUp.Y = e.Y;
        }
    }
}
