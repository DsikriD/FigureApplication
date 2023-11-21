using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Microsoft.Diagnostics.Runtime;

namespace FigureApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Program>();

        }


        [Benchmark(Description = "Circle")]
        public void TestCircle()
        {
            Figure Circle = new Circle(342);
            Console.WriteLine(Circle.getArea());
        }
        [Benchmark(Description = "Trigular")]
        public void TestTrigulare()
        {
            Triangle Triangle = new Triangle(5,3,4);
            Console.WriteLine(Triangle.IsRectangular);
        }





    }
}