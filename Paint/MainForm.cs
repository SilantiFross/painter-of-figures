using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Paint.Classes;
using Paint.Classes.Figures;
using Point = Paint.Classes.Figures.Point;

namespace Paint
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, System.EventArgs e)
        {
            var ellipse = new Ellipse(new Point(1000, 400), 170, 100, Color.Red);
            var line = new Line(new Point(400, 100), new Point(600, 700), Color.Black);
            var rectangle = new Classes.Figures.Rectangle(new Point(700, 600), 300, 300, Color.Blue);
            var triangle = new Triangle(new Point(800, 300), new Point(800, 400), new Point(700, 200), Color.Red);

            #region InitializationListLines
            var listOfLines = new List<Line>()
            {
                new Line(new Point(100, 300), new Point(100, 400), Color.Green),
                new Line(new Point(100, 400), new Point(200, 100), Color.Red),
                new Line(new Point(200, 100), new Point(600, 800), Color.Black)
            };
            #endregion

            var polyline = new Polyline(listOfLines);

            var listOfShape = new List<Shape>()
            {
                ellipse, triangle, line, rectangle, polyline
            };

            var listOfFigures = new ListOfFigures(listOfShape);
            listOfFigures.DrawingListOfFigures();
        }
    }
}
