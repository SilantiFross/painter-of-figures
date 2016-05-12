using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using Paint.Classes;

namespace Paint
{
    public partial class MainForm : Form
    {
        private MouseController mouseController = new MouseController();
        private CreatorShapes creatorShapes = new CreatorShapes();
        private DrawingShapes drawingShapes = new DrawingShapes();
        private StoreFigures storeFigures = new StoreFigures();

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
            storeFigures.ShapesList.Add(point);
        }

        private void buttonLine_Click(object sender, System.EventArgs e)
        {
            var line = creatorShapes.CreateLine(MouseController.PointMouseDown, MouseController.PointMouseUp,
                panelColor.BackColor);
            drawingShapes.Draw(line);
            storeFigures.ShapesList.Add(line);
        }

        private void buttonRectangle_Click(object sender, System.EventArgs e)
        {
            var rectangle = creatorShapes.CreateRectangle(MouseController.PointMouseDown, MouseController.PointMouseUp,
                panelColor.BackColor);
            drawingShapes.Draw(rectangle);
            storeFigures.ShapesList.Add(rectangle);
        }

        private void buttonEllipse_Click(object sender, System.EventArgs e)
        {
            var ellipse = creatorShapes.CreateEllipse(MouseController.PointMouseDown, MouseController.PointMouseUp,
                panelColor.BackColor);
            drawingShapes.Draw(ellipse);
            storeFigures.ShapesList.Add(ellipse);
        }

        private void buttonTriangle_Click(object sender, System.EventArgs e)
        {
            var triangle = creatorShapes.CreateTriangle(MouseController.PointMouseDown, MouseController.PointMouseUp,
                panelColor.BackColor);
            drawingShapes.Draw(triangle);
            storeFigures.ShapesList.Add(triangle);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var formatter = new XmlSerializer(typeof(StoreFigures));

            using (var fileStream = new FileStream("storage.xml", FileMode.Create))
            {
                formatter.Serialize(fileStream, storeFigures);
            }
        }
    }
}
