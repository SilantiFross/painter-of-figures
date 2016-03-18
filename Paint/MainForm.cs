using System.Windows.Forms;
using Paint.Classes;
using Paint.Classes.Figures;

namespace Paint
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            Main.GetPointMouseDown(e);
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            Main.GetPointMouseUp(e);
        }

        private void radioButtonPoint_CheckedChanged(object sender, System.EventArgs e)
        {
            Main.Shape = new Point(panelColor.BackColor);
        }

        private void radioButtonLine_CheckedChanged(object sender, System.EventArgs e)
        {
            Main.Shape = new Line(panelColor.BackColor);
        }

        private void radioButtonRectangle_CheckedChanged(object sender, System.EventArgs e)
        {
            Main.Shape = new Rectangle(panelColor.BackColor);
        }

        private void radioButtonEllipse_CheckedChanged(object sender, System.EventArgs e)
        {
            Main.Shape= new Ellipse(panelColor.BackColor);
        }

        private void radioButtonTriangle_CheckedChanged(object sender, System.EventArgs e)
        {
            Main.Shape = new Triangle(panelColor.BackColor);
        }

        private void panelColor_Click(object sender, System.EventArgs e)
        {
            Main.GetColorShape(panelColor);
        }
    }
}
