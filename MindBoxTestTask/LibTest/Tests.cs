using NUnit.Framework;
using Lib;

namespace LibTest
{
    [TestFixture]
    public class Tests
    {
        private CalcFiguresArea cfa = new CalcFiguresArea();

        // testing the calculation of the area of a circle by radius
        // input - 5; output - 78.54
        [Test]
        public void CircleAreaCalcTest()
        {
            int radius = 5;
            double expected = 78.54;
            
            double result = cfa.CircleAreaCalc(radius);
            Assert.AreEqual(expected, result);
        }

        // testing the calculating the area of a triangle on three sides
        // input - 5, 4, 3; output - 6
        [Test]
        public void TriangleAreaCalcTest()
        {
            int a = 5;
            int b = 4;
            int c = 3;
            double expected = 6d;
            
            double result = cfa.TriangleAreaCalc(a, b, c);
            Assert.AreEqual(expected, result);
        }

        // checking the triangle for rectangularity
        [Test]
        public void IsTriangleRectangularTest()
        {
            int a = 5;
            int b = 4;
            int c = 3;
            
            bool result = cfa.IsTriangleRectangular(a, b, c);
            Assert.True(result);
        }
    }
}