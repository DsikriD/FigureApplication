using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureApplication
{
    internal class Circle : Figure
    {
        private double Radius;

        public Circle(double Radius) : base(Radius>0? Math.PI * Math.Pow(Radius, 2):0)
        {
            
        }

        public double getArea() => area;

    }
}
