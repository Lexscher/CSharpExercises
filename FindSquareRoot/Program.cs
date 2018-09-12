using System;

namespace FindSquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine();
                Console.Write("Please enter a number to find the square root or \"q\" to quit ");
                string sNumber = Console.ReadLine();
                if (sNumber.ToLower() == "q") return;
                if (!double.TryParse(sNumber, out double number))
                {
                    Console.WriteLine($"{sNumber} is not a number. Sorry!");
                    continue;
                }
                if (number < 0)
                {
                    Console.WriteLine("The number needs to be positive.");
                    continue;
                }

                double squareRoot = Math.Sqrt(number); // <~ Math.PI & Math.E are fields
                Console.WriteLine($"The sqare root of {number} is {squareRoot}.");

            } // <~ Close While Loop
        }
    }
}