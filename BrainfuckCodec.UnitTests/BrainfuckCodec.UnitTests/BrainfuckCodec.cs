using System.Text.RegularExpressions;
using Tools;

namespace Codecs
{
    public static class BrainfuckCodec
    {
        public static char[] brainfuckInstructions = { '>', '<', '+', '-', '.', ',', '[', ']' };
        public static List<byte> compressedBytes = new List<byte>();
        public static ConversionType LatestConversion { get; private set; } = ConversionType.NotSet;
        public enum ConversionType
        {
            NotSet,
            Compression,
            Decompression,
        }
        public static IEnumerable<byte> CompressedBytes { get { return compressedBytes; } }

        public static byte BinaryBrainfuckConvertToByte(byte count, char character)
        {
            if (!CharacterCountValid(count) || !brainfuckInstructions.Contains(character))
                throw new ArgumentException("Error: invalid byte convert format");
            return Convert.ToByte(Convert.ToString(count, 2).PadLeft(5, '0') + Convert.ToString(Array.IndexOf(brainfuckInstructions, character), 2).PadLeft(3, '0'), 2);
        }

        public static bool CharacterCountValid(byte count)
        {
            return count < 32;
        }

        public static bool CheckIfCompressionFlag(byte input)
        {
            return (input < 8 && input > 0);
        }

        public static string BrainfuckCompression(string input)
        {
            compressedBytes.Clear();
            IEnumerable<string> segmentEnumerator = StringToolbox.SplitAlikeSectionsToByteSizeSegments(StringToolbox.SplitToAlikeSections(input));
            string output;
            int tempSegmentSize;
            char tempSegmentChar;
            int tempSegmentMultiplier;
            byte tempSegmentRest;
            foreach (string segment in segmentEnumerator)
            {
                tempSegmentSize = segment.Length;
                tempSegmentChar = segment[0];
                tempSegmentRest = (byte)(tempSegmentSize % 32);
                tempSegmentMultiplier = (tempSegmentSize - tempSegmentRest) / 32;
                if (tempSegmentSize > 31)
                {
                    compressedBytes.Add(BinaryBrainfuckConvertToByte(0, brainfuckInstructions[tempSegmentMultiplier]));
                    compressedBytes.Add(BinaryBrainfuckConvertToByte(tempSegmentRest, tempSegmentChar));
                }
                else
                    compressedBytes.Add(BinaryBrainfuckConvertToByte((byte)tempSegmentSize, tempSegmentChar));
            }
            output = BrainfuckCodec.ToString();
            LatestConversion = ConversionType.Compression;
            return output;
        }

        public static string BrainfuckDecompression(string input)
        {
            if (input == null || !Regex.IsMatch(input, "^[01]+$") || input.Length % 8 != 0)
                throw new ArgumentException("Error: invalid decompression format");
            string output = "";
            byte tempCount;
            char tempChar;
            byte tempFlagMultiplier = 0;
            byte tempByte;
            bool flagFound = false;
            foreach (string byteString in StringToolbox.SplitBy(input, 8))
            {
                tempCount = Convert.ToByte(byteString.Substring(0, 5), 2);
                if (!CharacterCountValid(tempCount) || Convert.ToByte(byteString.Substring(5, 3), 2) > brainfuckInstructions.Length - 1)
                    throw new ArgumentException("Error: incorrect byte");
                tempByte = Convert.ToByte(byteString, 2);
                if (CheckIfCompressionFlag(tempByte) && !flagFound)
                {
                    tempFlagMultiplier = tempByte;
                    flagFound = true;
                }
                else
                {
                    tempChar = (char)brainfuckInstructions.GetValue(Convert.ToByte(byteString.Substring(5, 3), 2));
                    output += StringToolbox.CharactersCount(tempCount + tempFlagMultiplier * 32, tempChar);
                    flagFound = false;
                    tempFlagMultiplier = 0;
                }
            }
            LatestConversion = ConversionType.Decompression;
            return output;
        }
        public static string ToString()
        {
            return $"[{String.Join("] [", compressedBytes.Select<byte, string>(b => { return Convert.ToString(b, 2).PadLeft(8, '0'); }).ToArray())}]";
        }
    }
}
