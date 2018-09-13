using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation mathOp = MathOperation.ReadFromConsole();
            while(mathOp != null)
            {
                Console.WriteLine(mathOp);
                Console.WriteLine();
                mathOp = MathOperation.ReadFromConsole();
            }
        }
    }
}
