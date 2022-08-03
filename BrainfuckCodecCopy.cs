using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BrainfuckCompression
{
    public static class BrainfuckCodec
    {
        private static char[] brainfuckInstructions = { '>', '<', '+', '-', '.', ',', '[', ']' };

        private static string BinaryByteBrainfuckConvert(byte count, char character)
        {
            if (!CharacterCountValid(count) || !brainfuckInstructions.Contains(character))
            {
                throw new ArgumentException("Error: invalid byte convert format");
            }
            return Convert.ToString(count, 2).PadLeft(5, '0') + Convert.ToString(Array.IndexOf(brainfuckInstructions, character), 2).PadLeft(3, '0');
        }

        private static bool CharacterCountValid(byte count)
        {
            return count < 32;
        }

        public static string BrainfuckCompression(string input)
        {
            byte tempCount = 0;
            string output = "";
            char lastChar = input[0];
            int i = 0;
            foreach (char c in input.ToCharArray())
            {
                if (c.Equals(lastChar) && tempCount < 31)
                {
                    tempCount++;
                }
                else
                {
                    output += BinaryByteBrainfuckConvert(tempCount, lastChar);
                    tempCount = 1;
                }
                lastChar = c;
                if (i == input.ToCharArray().Length - 1)
                {
                    output += BinaryByteBrainfuckConvert(tempCount, c);
                    break;
                }
                i++;
            }
            return output;
        }

        public static string BrainfuckDecompression(string input)
        {
            if(input == null || !Regex.IsMatch(input, "^[01]+$") || input.Length % 8 != 0)
            {
                throw new ArgumentException("Error: invalid decompression format");
            }
            string output = "";
            byte tempCount;
            char tempChar;
            foreach (string byteString in StringToolbox.SplitBy(input, 8))
            {
                tempCount = Convert.ToByte(byteString.Substring(0, 5), 2);
                if (!CharacterCountValid(tempCount) || Convert.ToByte(byteString.Substring(5, 3), 2) > brainfuckInstructions.Length-1)
                {
                    throw new ArgumentException("Error: incorrect byte");
                }
                tempChar = (char)brainfuckInstructions.GetValue(Convert.ToByte(byteString.Substring(5, 3), 2));
                output += StringToolbox.CharactersCount(tempCount, tempChar);
            }
            return output;
        }
    }
}
