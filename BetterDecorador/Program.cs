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

        }
    }
}
