using AreaCalculator.Methods;
using AreaCalculator.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AreaCalculator
{
    public class Calculations
    {
        public double GetSquareOfShape(params double[] sides)
        {
            return DefineShape.BySides(sides).GetSquare();
        }     
    }
}
