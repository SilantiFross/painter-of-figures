using System;
using System.Drawing;
using System.Xml.Serialization;

namespace Paint.Classes.Figures
{
    [Serializable]
    public abstract class Shape
    {
        [XmlIgnore]
        public Color Color { get; set; }

        public Shape()
        { }

        [XmlElement("ColorArgb")]
        public int BackColorAsArgb
        {
            get { return Color.ToArgb(); }
            set { Color = Color.FromArgb(value); }
        }

    }
}
