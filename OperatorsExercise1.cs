using System;
using System.Dynamic;

namespace OperatorsExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($"");
            

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");

            Console.WriteLine("Please enter a radius to calculate the area");

            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            var area = AreaOfCircle(radius);

            Console.WriteLine($"{area} is the area of a circle wity a radius {radius}");
        }

        public static double AreaOfCircle(double radius)
        {
            return (Math.PI) * (radius * radius);
        }

    }
}
