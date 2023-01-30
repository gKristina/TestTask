using System;

namespace AreaCalculator.Shapes
{
    public class Circle : IShape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetSquare() => Math.Round(Math.Pow(Radius, 2) * Math.PI, 2);
        private double Radius { get; set; }
    }
}
