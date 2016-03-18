using System.Collections.Generic;

namespace Paint.Classes.Figures
{
    internal class Polyline: Shape
    {
        public List<Line> lines;

        public Polyline()
        {
            //
        }

        public Polyline(List<Line> points)
        {
            this.lines = points;
        }

    }
}
