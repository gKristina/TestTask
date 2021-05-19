using System;
using AreaCalculator;
using ConsoleCalculator.Messages;
using ConsoleCalculator.Helpers;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            UImessages.GetSides();

            string inputLine = Console.ReadLine();

            double[] inputArray = Converter.FromStringToDouble(inputLine);
         
            double result = new Calculations().GetSquareOfShape(inputArray);

            UImessages.WriteResult(result);

            Console.ReadLine();
            
        }
    }
}
