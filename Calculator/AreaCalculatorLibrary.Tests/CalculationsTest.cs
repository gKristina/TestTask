using AreaCalculator;

namespace AreaCalculatorLibrary.Tests
{
    public class CalculationsTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CircleSquuare_Test()
        {
            var circleRadius = new double[] { 10 };
            var expectedSquare = 314.16;

            var result = Calculations.GetSquareOfShape(circleRadius);

            Assert.That(result, Is.EqualTo(expectedSquare));
        }

        [Test]
        public void Square_Test()
        {
            var squareSides = new double[] { 10, 10 };
            var expectedSquare = 100;

            var result = Calculations.GetSquareOfShape(squareSides);

            Assert.That(result, Is.EqualTo(expectedSquare));
        }

        [Test]
        public void TriangleSquare_Test()
        {
            var triangleSides = new double[] { 10, 8, 5 };
            var expectedSquare = 19.81;

            var result = Calculations.GetSquareOfShape(triangleSides);

            Assert.That(result, Is.EqualTo(expectedSquare));
        }

        [Test]
        public void GetSquare_TypeNotSupported()
        {
            var sides = new double[] { 10, 8, 5, 10 };

            Assert.Throws<Exception>(() => Calculations.GetSquareOfShape(sides));
        }
    }
}