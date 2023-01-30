using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AreaCalculator.Shapes
{
    public class Triangle : IShape
    {
        public Triangle(double[] sides)
        {
            SideA = sides[0];
            SideB = sides[1];
            SideC = sides[2];
        }
        private double SideA { get; set; }
        private double SideB { get; set; }
        private double SideC { get; set; }

        public double GetSquare()
        {
            double halfPerimeter = (SideA + SideB + SideC) / 2;

            return Math.Round(Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC)), 2);           
        }

        public bool IsRightTriangle
        {
            get
            {
                List<double> sides = new List<double>() { SideA, SideB, SideC };

                sides.Sort();

                double longerSide = sides.Max();

                double hypotenuze = Math.Sqrt(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2));

                return longerSide == hypotenuze;
            }
        }
    }
}
