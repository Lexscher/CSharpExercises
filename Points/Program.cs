using System;

namespace Points
{
    class Program
    {
        static void Main(string[] args)
        {
            CPoint cp = new CPoint();
            SPoint sp = new SPoint();
            Console.WriteLine($"{cp.X}, {cp.Y}, {sp.X}, {sp.Y}"); // 0, 0, 0, 0
            ChangePoints(cp, sp);
            Console.WriteLine($"{cp.X}, {cp.Y}, {sp.X}, {sp.Y}"); // 10, 10, 10, 10
        }

        static void ChangePoints(CPoint cp, SPoint sp)
        {
            cp.X = cp.Y = sp.X = sp.Y = 10;
        }
    }
}
