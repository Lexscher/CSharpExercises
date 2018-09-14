using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            IMathOperation mathOp = MathOperation.ReadFromConsole();
            while(mathOp != null)
            {
                Console.WriteLine($"The left operand is {mathOp.LeftOperand}");
                Console.WriteLine($"The right operand is {mathOp.RightOperand}");
                Console.WriteLine(mathOp);
                Console.WriteLine();
                mathOp = MathOperation.ReadFromConsole();
            }
        }
    }
}
