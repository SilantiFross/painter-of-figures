using System.Windows.Forms;

namespace Paint.Classes
{
    class ControllerColors
    {
        public void SetColorShape(Panel panelColor)
        {
            var colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                panelColor.BackColor = colorDialog.Color;
            }
        }
    }
}
