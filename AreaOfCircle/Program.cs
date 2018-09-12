using System;

namespace AreaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine();
                Console.Write("Please enter a number to find the square root or \"q\" to quit ");
                string sRadius = Console.ReadLine();
                if (sRadius.ToLower() == "q") return;
                if (!double.TryParse(sRadius, out double radius))
                {
                    Console.WriteLine($"{radius} is not a number. Sorry!");
                    continue;
                } 
                double area = radius * radius * Math.PI; // <~ Math.PI & Math.E are fields
                Console.WriteLine($"The area of a circle of radius {radius:F3} is {area:F3}.");
            }
        }
    }
}
