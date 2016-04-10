using System.Drawing;
using System.Windows.Forms;
using Paint.Classes;
using Paint.Classes.Figures;

namespace Paint
{
    public partial class MainForm : Form
    {
        private readonly MouseController mouseController = new MouseController();
        private readonly CreatorShapes creatorShapes = new CreatorShapes();
        //private readonly DrawingShapes drawingShapes = new DrawingShapes();

        public MainForm()
        {
            InitializeComponent();
        }

        private void panelColor_Click(object sender, System.EventArgs e)
        {
            creatorShapes.SetColorShape(panelColor);
        }

        private void buttonPoint_Click(object sender, System.EventArgs e)
        {
            var point = creatorShapes.CreatePoint(mouseController.PointMouseDown, panelColor.BackColor);
            //drawingShapes.Draw(point);
            StoreFigures.ShapesList.Add(point);
        }

        private void buttonLine_Click(object sender, System.EventArgs e)
        {
            var line = creatorShapes.CreateLine(mouseController.PointMouseDown, mouseController.PointMouseUp,
                panelColor.BackColor);
            //drawingShapes.Draw(line);
            StoreFigures.ShapesList.Add(line);
        }

        private void buttonRectangle_Click(object sender, System.EventArgs e)
        {
            var rectangle = creatorShapes.CreateRectangle(mouseController.PointMouseDown, mouseController.PointMouseUp,
                panelColor.BackColor);
            //drawingShapes.Draw(rectangle);
            StoreFigures.ShapesList.Add(rectangle);
        }

        private void buttonEllipse_Click(object sender, System.EventArgs e)
        {
            var ellipse = creatorShapes.CreateEllipse(mouseController.PointMouseDown, mouseController.PointMouseUp,
                panelColor.BackColor);
            //drawingShapes.Draw(ellipse);
            StoreFigures.ShapesList.Add(ellipse);
        }

        private void buttonTriangle_Click(object sender, System.EventArgs e)
        {
            var triangle = creatorShapes.CreateTriangle(mouseController.PointMouseDown, mouseController.PointMouseUp,
                panelColor.BackColor);
            //drawingShapes.Draw(triangle);
            StoreFigures.ShapesList.Add(triangle);
        }

        private void BoxCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            mouseController.IsMouseDown = true;
            mouseController.GetPointMouseDown(e);
        }

        private void BoxCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            mouseController.IsMouseDown = false;
            mouseController.GetPointMouseUp(e);
        }

        private void BoxCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseController.IsMouseDown) return;

            mouseController.PointMouseUp.x = e.X;
            mouseController.PointMouseUp.y = e.Y;
            BoxCanvas.Invalidate();
        }

        private void BoxCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (!mouseController.IsMouseDown) return;

            var drawingShapes = new DrawingShapes(BoxCanvas);
            var ellipse = creatorShapes.CreateEllipse(mouseController.PointMouseDown, mouseController.PointMouseUp,
                panelColor.BackColor);
            drawingShapes.Draw(ellipse);
        }
    }
}
