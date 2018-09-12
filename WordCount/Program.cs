using System;
using System.IO;


namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("An argument is expected.");
                return;
            }
            if (!File.Exists(args[0]))
            {
                Console.WriteLine($"File not found: {args[0]}");
            }
            string text = File.ReadAllText(args[0]);
            const string word = "whale";
            int position = text.IndexOf(word);
            int count = 0;
            while (position >= 0)
            {
                count++;
                position = text.IndexOf(word, position + 1);
            }
            Console.WriteLine($"The word \"{word}\" was found {count} times.");
        }
    }
}
