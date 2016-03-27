﻿using System.Windows.Forms;
using Paint.Classes;

namespace Paint
{
    public partial class MainForm : Form
    {
        readonly MouseController _mouseController = new MouseController();

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
            CreatorShapes.SetColorShape(panelColor);
        }

        private void buttonPoint_Click(object sender, System.EventArgs e)
        {
            CreatorShapes.CreatePoint(MouseController.PointMouseDown, panelColor.BackColor);
        }

        private void buttonLine_Click(object sender, System.EventArgs e)
        {
            CreatorShapes.CreateLine(MouseController.PointMouseDown, MouseController.PointMouseUp,
                panelColor.BackColor);
        }

        private void buttonRectangle_Click(object sender, System.EventArgs e)
        {
            CreatorShapes.CreateRectangle(MouseController.PointMouseDown, MouseController.PointMouseUp,
                panelColor.BackColor);
        }

        private void buttonEllipse_Click(object sender, System.EventArgs e)
        {
            CreatorShapes.CreateEllipse(MouseController.PointMouseDown, MouseController.PointMouseUp,
                panelColor.BackColor);
        }

        private void buttonTriangle_Click(object sender, System.EventArgs e)
        {
            CreatorShapes.CreateTriangle(MouseController.PointMouseDown, MouseController.PointMouseUp,
                panelColor.BackColor);
        }
    }
}
