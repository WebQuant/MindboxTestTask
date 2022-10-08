using System;

namespace Lib
{
    public class CalcFiguresArea
    {
        public double CircleAreaCalc(int r)
        {
            Console.Write("Result: ");
            return Math.Round(Math.PI * Math.Pow(r, 2), 2);
        }
        
        public double TriangleAreaCalc(int a, int b, int c)
        {
            double p = (a + b + c) / 2d;
            
            Console.Write("Result: ");
            return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);
        }

        public bool IsTriangleRectangular(int a, int b, int c)
        {
            // multiplication can be replaced by a square using the Math.Pow() function
            if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a)) 
                return true;
            return false;
        }
    }
}