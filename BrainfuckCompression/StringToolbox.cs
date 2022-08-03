using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainfuckCompression
{
    internal static class StringToolbox
    {
        public static IEnumerable<string> SplitBy(this string input, int size)
        {
            if (String.IsNullOrEmpty(input) || size < 1)
            {
                throw new ArgumentException();
            }

            for (int i = 0; i < input.Length; i += size)
            {
                yield return input.Substring(i, Math.Min(size, input.Length - i));
            }
        }

        public static string CharactersCount(int numberOfCharacters, char character)
        {
            string output = "";
            for (int i = 0; i < numberOfCharacters; i++)
                output += character;
            return output;
        }
    }
}
