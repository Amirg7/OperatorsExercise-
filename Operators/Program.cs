using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            var div = a / b;
            var mod = a % b;

            Console.WriteLine($"{a}/{b} is {div} remainder {mod}");

            //Allow user to input radius
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());

            //Calculate area of the circle
            var areaOfCircle = CalculateArea(20);

            
            Console.WriteLine($"The area of a circle with radius of {radius} is {areaOfCircle}");
        }

        public static double CalculateArea(double radius)
        {
            return Math.PI * (radius * radius);
        }



    }


}
