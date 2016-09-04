using Microsoft.VisualStudio.TestTools.UnitTesting;
using Paint.Classes;
using System.Drawing;
using System.Windows.Forms;

namespace Paint.Tests
{
    [TestClass()]
    public class MainFormTests
    {
        [TestMethod()]
        public void MainFormTest()
        {
            CreatorShapes creatorShapes = new CreatorShapes();

            var actual = creatorShapes.CreatePoint(new Classes.Figures.Point(0, 0), Color.Black);

            var expected = new Classes.Figures.Point(0, 0);

            expected.Color = Color.Black;

            Assert.AreEqual(actual, expected);
        }
    }
}