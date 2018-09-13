using System;
namespace Calculator
{
    public class MathOperation
    {
        const string Operators = "+-*/%";
        public static MathOperation ReadFromConsole()
        {
            Console.Write("Enter the left operand: ");
            string sLeft = Console.ReadLine();
            if (!double.TryParse(sLeft, out double leftOp)) return null;
            Console.Write("Enter the right operand: ");
            if (!double.TryParse(Console.ReadLine(), out double rightOp)) return null;
            Console.Write($"Enter an operator ({Operators}): ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (!Operators.Contains(c)) return null;
            return new MathOperation
            {
                LeftOperand = leftOp,
                RightOperand = rightOp,
                Operator = c
            };
        }

        private MathOperation() { }

        public double LeftOperand { get; private set; }
        public double RightOperand { get; private set; }
        public char Operator { get; private set; }
        public double Result
        {
            get
            {
                switch (Operator)
                {
                    case '+': return LeftOperand + RightOperand;
                    case '-': return LeftOperand - RightOperand;
                    case '*': return LeftOperand * RightOperand;
                    case '/': return LeftOperand / RightOperand;
                    case '%': return LeftOperand % RightOperand;
                    default: throw new Exception($"Unexpected Operator: {Operator}");
                }
            }
        }
        public override string ToString()
        {
            return $"{LeftOperand} {Operator} {RightOperand} = {Result}";
        }
    }
}