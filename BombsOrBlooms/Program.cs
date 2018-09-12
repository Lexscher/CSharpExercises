using System;
using System.Threading;

namespace BombsOrBlooms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you prefer booms or blooms?");
            Console.Write("Enter b (bomb) or f (flower): ");
            ConsoleKeyInfo k = Console.ReadKey();
            char kc = k.KeyChar;
            kc = Char.ToLower(kc);
            if (kc == 'b') 
            {
                CountdownAndFlash(ConsoleColor.Black, "Booming", ConsoleColor.Red, ConsoleColor.Yellow);
            }
            else
            {
                CountdownAndFlash(ConsoleColor.Green, "Blooming", ConsoleColor.Cyan, ConsoleColor.Red);
            }
        }

        static void CountdownAndFlash(
            ConsoleColor bkgColor,
            string msg,
            ConsoleColor flashColor1,
            ConsoleColor flashColor2
        ) 
        {
            Console.BackgroundColor = bkgColor;
            Console.Clear();
            int countDown = 5;
            while (countDown > 0)
            {
                Console.WriteLine($"{msg} in {countDown--} seconds ...");
                Thread.Sleep(1000);
            }
            countDown = 5;
            while (countDown > 0)
            {
                Console.BackgroundColor = flashColor1;
                Console.Clear();
                Thread.Sleep(500);
                Console.BackgroundColor = flashColor2;
                Console.Clear();
                Thread.Sleep(500);
                countDown--;
            }
        } // <~ Countdown and Flash method (Closed).
    }
}
