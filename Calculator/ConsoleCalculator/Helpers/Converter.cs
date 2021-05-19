using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator.Helpers
{
    public class Converter
    {
        public static double[] FromStringToDouble(string inputLine)
        {
            string[] splitedLine = inputLine.Split(new char[] { ' ' });

            double[] convertedDouble = new double[splitedLine.Length];

            for (var i = 0; i < splitedLine.Length; i++)
            {
                convertedDouble[i] = Convert.ToDouble(splitedLine[i]);
            }

            return convertedDouble;
        }
    }
}
