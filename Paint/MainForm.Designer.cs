namespace Paint
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonEllipse = new System.Windows.Forms.RadioButton();
            this.radioButtonLine = new System.Windows.Forms.RadioButton();
            this.radioButtonPoint = new System.Windows.Forms.RadioButton();
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.radioButtonTriangle = new System.Windows.Forms.RadioButton();
            this.groupBoxShapes = new System.Windows.Forms.GroupBox();
            this.panelColor = new System.Windows.Forms.Panel();
            this.groupBoxShapes.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonEllipse
            // 
            this.radioButtonEllipse.AutoSize = true;
            this.radioButtonEllipse.Location = new System.Drawing.Point(6, 92);
            this.radioButtonEllipse.Name = "radioButtonEllipse";
            this.radioButtonEllipse.Size = new System.Drawing.Size(55, 17);
            this.radioButtonEllipse.TabIndex = 1;
            this.radioButtonEllipse.Text = "Ellipse";
            this.radioButtonEllipse.UseVisualStyleBackColor = true;
            this.radioButtonEllipse.CheckedChanged += new System.EventHandler(this.radioButtonEllipse_CheckedChanged);
            // 
            // radioButtonLine
            // 
            this.radioButtonLine.AutoSize = true;
            this.radioButtonLine.Location = new System.Drawing.Point(6, 46);
            this.radioButtonLine.Name = "radioButtonLine";
            this.radioButtonLine.Size = new System.Drawing.Size(45, 17);
            this.radioButtonLine.TabIndex = 2;
            this.radioButtonLine.TabStop = true;
            this.radioButtonLine.Text = "Line";
            this.radioButtonLine.UseVisualStyleBackColor = true;
            this.radioButtonLine.CheckedChanged += new System.EventHandler(this.radioButtonLine_CheckedChanged);
            // 
            // radioButtonPoint
            // 
            this.radioButtonPoint.AutoSize = true;
            this.radioButtonPoint.Location = new System.Drawing.Point(6, 23);
            this.radioButtonPoint.Name = "radioButtonPoint";
            this.radioButtonPoint.Size = new System.Drawing.Size(49, 17);
            this.radioButtonPoint.TabIndex = 3;
            this.radioButtonPoint.Text = "Point";
            this.radioButtonPoint.UseVisualStyleBackColor = true;
            this.radioButtonPoint.CheckedChanged += new System.EventHandler(this.radioButtonPoint_CheckedChanged);
            // 
            // radioButtonRectangle
            // 
            this.radioButtonRectangle.AutoSize = true;
            this.radioButtonRectangle.Location = new System.Drawing.Point(6, 69);
            this.radioButtonRectangle.Name = "radioButtonRectangle";
            this.radioButtonRectangle.Size = new System.Drawing.Size(74, 17);
            this.radioButtonRectangle.TabIndex = 5;
            this.radioButtonRectangle.Text = "Rectangle";
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            this.radioButtonRectangle.CheckedChanged += new System.EventHandler(this.radioButtonRectangle_CheckedChanged);
            // 
            // radioButtonTriangle
            // 
            this.radioButtonTriangle.AutoSize = true;
            this.radioButtonTriangle.Location = new System.Drawing.Point(6, 115);
            this.radioButtonTriangle.Name = "radioButtonTriangle";
            this.radioButtonTriangle.Size = new System.Drawing.Size(63, 17);
            this.radioButtonTriangle.TabIndex = 6;
            this.radioButtonTriangle.Text = "Triangle";
            this.radioButtonTriangle.UseVisualStyleBackColor = true;
            this.radioButtonTriangle.CheckedChanged += new System.EventHandler(this.radioButtonTriangle_CheckedChanged);
            // 
            // groupBoxShapes
            // 
            this.groupBoxShapes.Controls.Add(this.radioButtonRectangle);
            this.groupBoxShapes.Controls.Add(this.radioButtonTriangle);
            this.groupBoxShapes.Controls.Add(this.radioButtonPoint);
            this.groupBoxShapes.Controls.Add(this.radioButtonEllipse);
            this.groupBoxShapes.Controls.Add(this.radioButtonLine);
            this.groupBoxShapes.Location = new System.Drawing.Point(12, 12);
            this.groupBoxShapes.Name = "groupBoxShapes";
            this.groupBoxShapes.Size = new System.Drawing.Size(81, 139);
            this.groupBoxShapes.TabIndex = 7;
            this.groupBoxShapes.TabStop = false;
            this.groupBoxShapes.Text = "Shapes";
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.Black;
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelColor.Location = new System.Drawing.Point(99, 12);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(20, 20);
            this.panelColor.TabIndex = 8;
            this.panelColor.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.groupBoxShapes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Paint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.groupBoxShapes.ResumeLayout(false);
            this.groupBoxShapes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButtonEllipse;
        private System.Windows.Forms.RadioButton radioButtonLine;
        private System.Windows.Forms.RadioButton radioButtonPoint;
        private System.Windows.Forms.RadioButton radioButtonRectangle;
        private System.Windows.Forms.RadioButton radioButtonTriangle;
        private System.Windows.Forms.GroupBox groupBoxShapes;
        private System.Windows.Forms.Panel panelColor;
    }
}

