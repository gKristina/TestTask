using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator.Messages
{
    public static class UImessages
    {
        //public void Greeting()
        //{
        //    Console.WriteLine("");
        //}
        public static void GetSides()
        {
            Console.WriteLine("Enter radius of circle or sides of triangle");
        }

        public static void WriteResult(double result)
        {
            Console.WriteLine($"The square is {result}");
        }
    }
}
