using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AreaCalculator.Shapes
{
    public class Triangle : IShape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public int SideCount => 3;

        public double GetSquare()
        {
            double halfPerimeter = SideA + SideB + SideC / 2;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));           
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
