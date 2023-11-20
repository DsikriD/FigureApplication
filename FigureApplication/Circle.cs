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

        public Circle(double Radius)
        {
            try
            {
                if (Radius <= 0)
                    throw new ArgumentOutOfRangeException(nameof(Radius), " must be positive ");
                area = Math.PI * Math.Pow(Radius, 2);
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }  
        }

        public double getArea() => area;

    }
}
