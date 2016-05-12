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

        [XmlElement("XMLColor")]
        public int BackColorAsArgb
        {
            get { return Color.ToArgb(); }
            set { Color = Color.FromArgb(value); }
        }

        public Shape()
        { }
    }
}
