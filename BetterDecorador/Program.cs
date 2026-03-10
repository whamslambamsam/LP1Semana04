using System;

namespace BetterDecorador
{
    public class Program
    {
        static string Decor(string s, char dec, int n)
        {
            string deco = new(dec, n);
            return $"{deco} {s} {deco}";
        }

        static void Main(string[] args)
        {
            string line = args[0];
            char character = Convert.ToChar(args[1]);
            int num = Convert.ToInt32(args[2]);

            Console.WriteLine(Decor(line, character, num));
        }
    }
}
