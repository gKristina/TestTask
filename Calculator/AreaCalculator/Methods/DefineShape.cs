using AreaCalculator.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AreaCalculator.Methods
{
    public class DefineShape
    {
        static Circle circle = new Circle();
        static Triangle triangle = new Triangle();
        public static IShape BySides(params double[] shape)
        {
            int sideCount = shape.Count();

            if (sideCount == circle.SideCount)
            {
                circle.Radius = shape.First();
                return circle;
            }
            else
            {
                triangle.SideA = shape[0];
                triangle.SideB = shape[1];
                triangle.SideC = shape[2];
                return triangle;
            }
        }
    }
}
