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
        public bool IsRectangular { get;}

        public Triangle(double a, double b, double c) : base ( 
            ((a <= 0 || b <= 0 || c <= 0) && (a + b < c || b + c < a || a + c < b)) ? 0 : Math.Sqrt((a + b + c)/2 * ((a + b + c)/2 - a) * ((a + b + c) / 2 - b) * ((a + b + c) / 2 - c)))
        {
            if(area!=0)
                IsRectangular = (a==Math.Sqrt(Math.Pow(b,2)+Math.Pow(c,2))) 
                || (b == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(c, 2))) 
                || (c == Math.Sqrt(Math.Pow(b, 2) + Math.Pow(a, 2))) ? true : false;
        }

        public bool  getRectangular()
        {
            return IsRectangular;
        }

        public double getArea() => area;
        
    }
}
