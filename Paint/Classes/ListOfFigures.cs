using System.Collections.Generic;
using Paint.Classes.Figures;

namespace Paint.Classes
{
    internal class ListOfFigures
    {
        private List<Shape> listOfFigure;

        public ListOfFigures(List<Shape> listOfShapes)
        {
            this.listOfFigure = listOfShapes;
        }

        public void DrawingListOfFigures()
        { 
            foreach (var shape in listOfFigure)
            {
                dynamic inheritorShape = shape;
                DrawingShapes.Draw(inheritorShape);
            }
        }

        public void Add(Shape figureToAdding)
        {
            listOfFigure.Add(figureToAdding);
        }

        public void Delete(Shape figureToRemove)
        {
            listOfFigure.Remove(figureToRemove);
        }
    }
}
