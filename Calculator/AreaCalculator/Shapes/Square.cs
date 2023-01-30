using AreaCalculator.Shapes;

namespace AreaCalculatorLibrary.Shapes
{
    public class Square : IShape
    {
        public Square(double[] sides)
        {
            SideA = sides[0];
            SideB = sides[1];
        }

        private double SideA { get; set; }
        private double SideB { get; set; }

        public double GetSquare()
        {
            return SideA * SideB;
        }
    }
}
