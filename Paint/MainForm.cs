using System;
using System.Windows.Forms;
using Paint.Classes;

namespace Paint
{
    public partial class MainForm : Form
    {
        private MouseController mouseController = new MouseController();
        private ControllerColors controllerColors = new ControllerColors();
        private ShapesComposite shapesComposite = new ShapesComposite();

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
            controllerColors.SetColorShape(panelColor);
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            var point = shapesComposite.creatorShapes.CreatePoint(mouseController.PointMouseDown, panelColor.BackColor);
            shapesComposite.drawingShapes.Draw(point);
            shapesComposite._storeFigures.ShapesList.Add(point);
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            var line = shapesComposite.creatorShapes.CreateLine(mouseController.PointMouseDown, mouseController.PointMouseUp,
                panelColor.BackColor);
            shapesComposite.drawingShapes.Draw(line);
            shapesComposite._storeFigures.ShapesList.Add(line);
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            var rectangle = shapesComposite.creatorShapes.CreateRectangle(mouseController.PointMouseDown, mouseController.PointMouseUp,
                panelColor.BackColor);
            shapesComposite.drawingShapes.Draw(rectangle);
            shapesComposite._storeFigures.ShapesList.Add(rectangle);
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            var ellipse = shapesComposite.creatorShapes.CreateEllipse(mouseController.PointMouseDown, mouseController.PointMouseUp,
                panelColor.BackColor);
            shapesComposite.drawingShapes.Draw(ellipse);
            shapesComposite._storeFigures.ShapesList.Add(ellipse);
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            var triangle = shapesComposite.creatorShapes.CreateTriangle(mouseController.PointMouseDown, mouseController.PointMouseUp,
                panelColor.BackColor);
            shapesComposite.drawingShapes.Draw(triangle);
            shapesComposite._storeFigures.ShapesList.Add(triangle);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var xmlSerialize = new XmlSerialize();

            xmlSerialize.SerializeStore(shapesComposite._storeFigures);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            var xmlDeserialize = new XmlSerialize();

            shapesComposite._storeFigures = xmlDeserialize.DeserializeStore();
                
            foreach (dynamic shapeInList in shapesComposite._storeFigures.ShapesList)
                shapesComposite.drawingShapes.Draw(shapeInList);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
