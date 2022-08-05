using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tools
{
    internal static class StringToolbox
    {
        public static IEnumerable<string> SplitBy(this string input, int size)
        {
            if (String.IsNullOrEmpty(input) || size < 1)
                throw new ArgumentException();
            for (int i = 0; i < input.Length; i += size)
                yield return input.Substring(i, Math.Min(size, input.Length - i));
        }

        public static IEnumerable<string> SplitToAlikeSections(this string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException();
            int varSize = 0;
            string tempInput = input;
            int lastTempInputLenght;
            for (int i = 0; i < input.Length; i += varSize)
            {
                lastTempInputLenght = tempInput.Length;
                tempInput = tempInput.TrimStart(input[i]);
                varSize = (lastTempInputLenght - tempInput.Length);
                yield return input.Substring(i, varSize);
            }
        }

        public static IEnumerable<string> SplitAlikeSectionsToByteSizeSegments(this IEnumerable<string> input)
        {
            if (input == null)
                throw new ArgumentException();
            List<string> output = new List<string>();
            int segmentRest;
            int segmentMultiplier;
            foreach (string segment in input)
            {
                segmentRest = segment.Length % 255;
                segmentMultiplier = (segment.Length - segmentRest) / 255;
                output.AddRange(Enumerable.Repeat(CharactersCount(255, segment[0]), segmentMultiplier));
                if(segmentRest > 0)
                output.Add(CharactersCount(segmentRest, segment[0]));
            }
            return output;
        }

        public static string CharactersCount(int numberOfCharacters, char character)
        {
            if (numberOfCharacters < 0)
                throw new ArgumentOutOfRangeException("Error: numberOfCharacters may not be less than zero");
            string output = "";
            for (int i = 0; i < numberOfCharacters; i++)
                output += character;
            return output;
        }
    }
}
