using AreaCalculator.Methods;
using AreaCalculator.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AreaCalculator
{
    public static class Calculations
    {
        public static double GetSquareOfShape(params double[] sides)
        {
            try
            {
                return ShapeBuilder.GetShapeBySides(sides).GetSquare();
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }     
    }
}
