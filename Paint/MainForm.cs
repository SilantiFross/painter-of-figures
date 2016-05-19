using System;
using System.Windows.Forms;
using Paint.Classes;

namespace Paint
{
    public partial class MainForm : Form
    {
        private MouseController mouseController = new MouseController();
        private CreatorShapes creatorShapes = new CreatorShapes();
        private DrawingShapes drawingShapes = new DrawingShapes();
        private StoreFigures _storeFigures = new StoreFigures();

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

        private void panelColor_Click(object sender, EventArgs e)
        {
            creatorShapes.SetColorShape(panelColor);
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            var point = creatorShapes.CreatePoint(MouseController.PointMouseDown, panelColor.BackColor);
            drawingShapes.Draw(point);
            _storeFigures.ShapesList.Add(point);
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            var line = creatorShapes.CreateLine(MouseController.PointMouseDown, MouseController.PointMouseUp,
                panelColor.BackColor);
            drawingShapes.Draw(line);
            _storeFigures.ShapesList.Add(line);
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            var rectangle = creatorShapes.CreateRectangle(MouseController.PointMouseDown, MouseController.PointMouseUp,
                panelColor.BackColor);
            drawingShapes.Draw(rectangle);
            _storeFigures.ShapesList.Add(rectangle);
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            var ellipse = creatorShapes.CreateEllipse(MouseController.PointMouseDown, MouseController.PointMouseUp,
                panelColor.BackColor);
            drawingShapes.Draw(ellipse);
            _storeFigures.ShapesList.Add(ellipse);
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            var triangle = creatorShapes.CreateTriangle(MouseController.PointMouseDown, MouseController.PointMouseUp,
                panelColor.BackColor);
            drawingShapes.Draw(triangle);
            _storeFigures.ShapesList.Add(triangle);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var xmlSerialize = new XmlSerialize();

            xmlSerialize.SerializeStore(_storeFigures);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            var xmlDeserialize = new XmlSerialize();

            _storeFigures = xmlDeserialize.DeserializeStore();
                
            foreach (dynamic shapeInList in _storeFigures.ShapesList)
                drawingShapes.Draw(shapeInList);
        }
    }
}
