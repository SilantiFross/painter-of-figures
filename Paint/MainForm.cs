using System.Windows.Forms;
using Paint.Classes;

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
            Main.DrawAllShapes();
        }
    }
}
