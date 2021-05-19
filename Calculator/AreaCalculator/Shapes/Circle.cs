using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator.Shapes
{
    public class Circle : IShape
    {
        public double Radius { get; set; }
        public int SideCount => 1;
        public double GetSquare() => Math.Pow(Radius, 2) * Math.PI;

    }
}
