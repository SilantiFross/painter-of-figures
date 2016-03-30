using System.Windows.Forms;
using Paint.Classes;

namespace Paint
{
    public partial class MainForm : Form
    {
        private readonly MouseController mouseController = new MouseController();
        private readonly CreatorShapes creatorShapes = new CreatorShapes();
        private readonly DrawingShapes drawingShapes = new DrawingShapes();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseController.GetPointMouseDown(e);
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseController.GetPointMouseUp(e);
        }

        private void panelColor_Click(object sender, System.EventArgs e)
        {
            creatorShapes.SetColorShape(panelColor);
        }

        private void buttonPoint_Click(object sender, System.EventArgs e)
        {
            var point = creatorShapes.CreatePoint(MouseController.PointMouseDown, panelColor.BackColor);
            drawingShapes.Draw(point);
            StoreFigures.ShapesList.Add(point);
        }

        private void buttonLine_Click(object sender, System.EventArgs e)
        {
            var line = creatorShapes.CreateLine(MouseController.PointMouseDown, MouseController.PointMouseUp,
                panelColor.BackColor);
            drawingShapes.Draw(line);
            StoreFigures.ShapesList.Add(line);
        }

        private void buttonRectangle_Click(object sender, System.EventArgs e)
        {
            var rectangle = creatorShapes.CreateRectangle(MouseController.PointMouseDown, MouseController.PointMouseUp,
                panelColor.BackColor);
            drawingShapes.Draw(rectangle);
            StoreFigures.ShapesList.Add(rectangle);
        }

        private void buttonEllipse_Click(object sender, System.EventArgs e)
        {
            var ellipse = creatorShapes.CreateEllipse(MouseController.PointMouseDown, MouseController.PointMouseUp,
                panelColor.BackColor);
            drawingShapes.Draw(ellipse);
            StoreFigures.ShapesList.Add(ellipse);
        }

        private void buttonTriangle_Click(object sender, System.EventArgs e)
        {
            var triangle = creatorShapes.CreateTriangle(MouseController.PointMouseDown, MouseController.PointMouseUp,
                panelColor.BackColor);
            drawingShapes.Draw(triangle);
            StoreFigures.ShapesList.Add(triangle);
        }
    }
}
