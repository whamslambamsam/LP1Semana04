using System;

namespace BetterDecorador
{
    public class Program
    {
        /// <summary>
        /// Gives a template for how the sentence will be written.
        /// </summary>
        /// <param name="s"></param>The string that'll be used.
        /// <param name="dec"></param>The character that will be used.
        /// <param name="n"></param>The number of times the character will be printed.
        /// <returns></returns>The template with the inputs given.
        static string Decor(string s, char dec, int n)
        {
            string deco = new(dec, n);
            return $"{deco} {s} {deco}";
        }

        /// <summary>
        /// Prints out the string given by the Decor method.
        /// </summary>
        /// <param name="args"></param>The elements inputted in the console.
        static void Main(string[] args)
        {
            string line = args[0];
            char character = Convert.ToChar(args[1]);
            int num = Convert.ToInt32(args[2]);

            Console.WriteLine(Decor(line, character, num));
        }
    }
}
