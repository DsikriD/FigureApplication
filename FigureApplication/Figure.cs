using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureApplication
{
    public abstract class Figure
    {
        protected double area;
        public double getArea() => area;

        public Figure(double area)
        {
            try
            {
                if (area <= 0)
                    throw new ArgumentOutOfRangeException("Some data has been entered");
                this.area = area;
            }

            catch (Exception ex){
                Console.WriteLine(ex.Message);   
            }
        }
    }


}
