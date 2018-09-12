using System;

namespace FindTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int myChoice = rnd.Next(1, 1001);
            while (true)
            {
                Console.WriteLine();
                Console.Write("Guess my number! Hint: It's between 1 and 1000 (inclusive) \"q\" to quit ");
                string sNumber = Console.ReadLine();
                if (sNumber.ToLower() == "q") return;
                if (!int.TryParse(sNumber, out int number))
                {
                    Console.WriteLine($"{sNumber} is not a number. Sorry!");
                    continue;
                }
                if (number < 1 || number > 1000)
                {
                    Console.WriteLine($"{number} is out of bounds. Needs to be between 1 and 1000 (inclusive)");
                    continue;
                }
                if (number < myChoice)
                {
                    Console.WriteLine($"{number} is too low!");
                    continue;
                }
                if (number > myChoice)
                {
                    Console.WriteLine($"{number} is too high!");
                    continue;
                }
                Console.WriteLine($"{number} is the same as {myChoice}! You got it!!");
                return;
            } // <~ Close While Loop
        }
    }
}
