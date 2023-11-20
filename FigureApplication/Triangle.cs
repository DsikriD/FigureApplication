using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureApplication
{
    public class Triangle : Figure
    {
        public bool IsRectangular { get; }

        public Triangle(double a, double b, double c) 
        {
            try
            {
                if (a <= 0 || b <= 0 || c <= 0)
                    throw new ArgumentOutOfRangeException("Sides must be positive.");
                else if (a + b < c || b + c < a || a + c < b)
                    throw new ArgumentException("Sides do not form a triangle");
                area = Math.Sqrt((a + b + c) * (a + b + c - a) * (a + b + c - b) * (a + b + c - c));

                IsRectangular = (a==Math.Sqrt(Math.Pow(b,2)+Math.Pow(c,2))) 
                    || (b == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(c, 2))) ||
                    (c == Math.Sqrt(Math.Pow(b, 2) + Math.Pow(a, 2))) ? true : false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }   
        }

        public bool getRectangular()
        {
            return IsRectangular;
        }

        public double getArea() => area;
        
    }
}
