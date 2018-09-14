using System;
namespace Calculator
{
    public interface IMathOperation
    {
        double LeftOperand { get; }
        double RightOperand { get; }
        char Operator { get; }
        double Result { get; }
    }
}
