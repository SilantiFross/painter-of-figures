using System.Windows.Forms;
using Paint.Classes;

namespace Paint
{
    public partial class MainForm : Form
    {
        private readonly MouseController _mouseController = new MouseController();
        private readonly CreatorShapes _creatorShapes = new CreatorShapes();
        private readonly DrawingShapes _drawingShapes = new DrawingShapes();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseController.GetPointMouseDown(e);
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseController.GetPointMouseUp(e);
        }

        private void panelColor_Click(object sender, System.EventArgs e)
        {
            _creatorShapes.SetColorShape(panelColor);
        }

        private void buttonPoint_Click(object sender, System.EventArgs e)
        {
            var point = _creatorShapes.CreatePoint(MouseController.PointMouseDown, panelColor.BackColor);
            _drawingShapes.Draw(point);
            StoreFigures.ShapesList.Add(point);
        }

        private void buttonLine_Click(object sender, System.EventArgs e)
        {
            var line = _creatorShapes.CreateLine(MouseController.PointMouseDown, MouseController.PointMouseUp,
                panelColor.BackColor);
            _drawingShapes.Draw(line);
            StoreFigures.ShapesList.Add(line);
        }

        private void buttonRectangle_Click(object sender, System.EventArgs e)
        {
            var rectangle = _creatorShapes.CreateRectangle(MouseController.PointMouseDown, MouseController.PointMouseUp,
                panelColor.BackColor);
            _drawingShapes.Draw(rectangle);
            StoreFigures.ShapesList.Add(rectangle);
        }

        private void buttonEllipse_Click(object sender, System.EventArgs e)
        {
            var ellipse = _creatorShapes.CreateEllipse(MouseController.PointMouseDown, MouseController.PointMouseUp,
                panelColor.BackColor);
            _drawingShapes.Draw(ellipse);
            StoreFigures.ShapesList.Add(ellipse);
        }

        private void buttonTriangle_Click(object sender, System.EventArgs e)
        {
            var triangle = _creatorShapes.CreateTriangle(MouseController.PointMouseDown, MouseController.PointMouseUp,
                panelColor.BackColor);
            _drawingShapes.Draw(triangle);
            StoreFigures.ShapesList.Add(triangle);
        }
    }
}
