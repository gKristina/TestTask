using AreaCalculator.Shapes;
using AreaCalculatorLibrary.Helpers;
using AreaCalculatorLibrary.Shapes;
using System;
using System.Linq;

namespace AreaCalculator.Methods
{
    public class ShapeBuilder
    {
        public static IShape GetShapeBySides(double[] sides)
        {
            int sideCount = sides.Count();

            switch ((ShapesSides)sideCount)
            {
                case ShapesSides.Circle:
                    return new Circle(sides[0]);
                case ShapesSides.Triangle:
                    return new Triangle(sides);
                case ShapesSides.Square:
                    return new Square(sides);
                default:
                    throw new Exception("This type is not supported");
            }
        }
    }
}
