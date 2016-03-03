using System.Collections.Generic;
using Paint.Classes.Figures;

namespace Paint.Classes
{
    internal class ListOfFigures
    {
        private List<Shape> listOfShapes;

        public ListOfFigures(List<Shape> listOfShapes)
        {
            this.listOfShapes = listOfShapes;
        }

        public void DrawingListOfFigures()
        { 
            foreach (var shape in listOfShapes)
            {
                dynamic inheritorShape = shape;
                DrawingShapes.Draw(inheritorShape);
            }
        }

        public void Add(Shape figureToAdding)
        {
            listOfShapes.Add(figureToAdding);
        }

        public void Delete(Shape figureToRemove)
        {
            listOfShapes.Remove(figureToRemove);
        }
    }
}
