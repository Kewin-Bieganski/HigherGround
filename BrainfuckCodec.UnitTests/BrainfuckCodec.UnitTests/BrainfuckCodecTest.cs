namespace BrainfuckCodec.UnitTests
{
    public class BrainfuckCodecTest
    {
        [Test]
        public void BinaryBrainfuckConvertToByte_WhenUsed_ShouldReturnByte()
        {
            Assert.Multiple(() =>
            {
                char inputCharacter = 'X';
                byte inputCount = 0;
                byte output = 0b00101101;
                byte resultByte;
                // Bad Path
                // Arrange
                inputCharacter = 'X';
                inputCount = 0;

                // Act
                // Assert
                Assert.That(() => Codecs.BrainfuckCodec.BinaryBrainfuckConvertToByte(inputCount, inputCharacter), Throws.Exception.TypeOf<ArgumentException>());

                // Normal Path
                // Arrange
                inputCharacter = ',';
                inputCount = 5;
                output = 0b00101101;

                // Act
                resultByte = Codecs.BrainfuckCodec.BinaryBrainfuckConvertToByte(inputCount, inputCharacter);

                // Assert
                Assert.AreEqual(output, resultByte);

                // Extreme Path - should work
                // Arrange
                inputCharacter = ']';
                inputCount = 31;
                output = 0b11111111;

                // Act
                resultByte = Codecs.BrainfuckCodec.BinaryBrainfuckConvertToByte(inputCount, inputCharacter);

                //Assert
                Assert.AreEqual(output, resultByte);
            });
        }

        [Test]
        public void BrainfuckCompression_WhenUsed_ShouldReturnPopulateCompressedBytesList()
        {
            Assert.Multiple(() =>
            {
                string input;
                byte[] output;
                byte[] result;


                // Bad Path
                // Arrange
                input = ">..!<<>..";

                // Act
                // Assert
                Assert.That(() => Codecs.BrainfuckCodec.BrainfuckCompression(input), Throws.Exception.TypeOf<ArgumentException>());

                // Normal Path
                // Arrange
                input = ">>>,,[[[[[";
                output = new byte[]
                {
                    0b00011000,
                    0b00010101,
                    0b00101110
                };

                // Act
                Codecs.BrainfuckCodec.BrainfuckCompression(input);
                result = Codecs.BrainfuckCodec.CompressedBytes.ToArray();
                // Assert
                Assert.AreEqual(output, result);

                // Extended Compression Path - should work
                // Arrange
                input = "................................";
                output = new byte[]
                {
                    0b00000001,
                    0b00000100
                };

                // Act
                Codecs.BrainfuckCodec.BrainfuckCompression(input);
                result = Codecs.BrainfuckCodec.CompressedBytes.ToArray();

                //Assert
                Assert.AreEqual(output, result);

                // Extreme Compression Path - should work
                // Arrange
                input = "...............................................................................................................................................................................................................................................................";
                output = new byte[]
                {
                    0b00000111,
                    0b011111100
                };

                // Act
                Codecs.BrainfuckCodec.BrainfuckCompression(input);
                result = Codecs.BrainfuckCodec.CompressedBytes.ToArray();

                //Assert
                Assert.AreEqual(output, result);

                // Flag overload Path - should create new compression container
                input = "................................................................................................................................................................................................................................................................";
                output = new byte[]
                {
                    0b00000111,
                    0b11111100,
                    0b00001100
                };

                // Act
                Codecs.BrainfuckCodec.BrainfuckCompression(input);
                result = Codecs.BrainfuckCodec.CompressedBytes.ToArray();

                //Assert
                Assert.AreEqual(output, result);
            });
        }

        [Test]
        public void BrainfuckDecompression_WhenUsed_ShouldReturnDecompressedString()
        {
            Assert.Multiple(() =>
            {
                string input;
                string output;
                string result;

                // Bad Path
                // Arrange
                input = "0000";

                // Act
                // Assert
                Assert.That(() => Codecs.BrainfuckCodec.BrainfuckDecompression(input), Throws.Exception.TypeOf<ArgumentException>());

                // Normal Path
                // Arrange
                input = "000110000000110100101001";
                output = ">>>,<<<<<";

                // Act
                result = Codecs.BrainfuckCodec.BrainfuckDecompression(input);

                // Assert
                Assert.AreEqual(output, result);

                // Extended Deompression Path - should work
                // Arrange
                input = "0000001111000001";
                output = "<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<";

                // Act
                result = Codecs.BrainfuckCodec.BrainfuckDecompression(input);

                //Assert
                Assert.AreEqual(output, result);

                // Extreme Decompression Path + Flag overload Path - should work
                // Arrange

                input = "0000011111111111000001111111111101001111";
                output = "]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]";

                // Act
                result = Codecs.BrainfuckCodec.BrainfuckDecompression(input);

                //Assert
                Assert.AreEqual(output, result);

                // Common code
                input = "010100100000111000001000001110100000100001010010000011100000100000111010000010000101001000001000000110100000100000001010001000010000101100001111000010000001001000001100000010000000101000001100001110100001010000011010000011000000100000010010000011000001000101111010000011000000100000001100000110100000110000110011000011000100001100001100000010000000101000001100000010000000110010000010000011100000100000111010000010000101001000001000000110100000100000001010001000010000101100001111000010000001001000001100000010000000101000001100001110100001010000011010000011000000100000010010000011000001000101111010000011000000100000001100000110100000110000110011000011000100001100001100000010000000101000001100000010000000110001100010000011100000100000111010000010000101001000001000000110100000100000001010001000010000101100001111000010000001001000001100000010000000101000001100001110100001010000011010000011000000100000010010000011000001000101111010000011000000100000001100000110100000110000110011000011000100001100001100000010000000101000001100000010000000110000010010000010000001101000001000000010100010000100001011000011110000100000010010000011000000100001010010000011100000100001110010000011100000100000111010000010000101001000001000000110100000100000001010001000010000101100001111000010000001001000001100000010000000101000001100001110100001010000011010000011000000100000010010000011000001000101111010000011000000100000001100000110100000110000110011000011000100001100001100000010000000101000001100000010000000110000011010000010000101001000001000000110100000100000001010001000010000101100001111000010000001001000001100000010000000101000001100001110100001010000011010000011000000100000010010000011000001000101111010000011000000100000001100000110100000110000110011000011000100001100001100000010000000101000001100000010000000110000001010000011000011101000010100000110100000110000001000000100100000110000010001011110100000110000001000000011000001101000001100001100110000110001000011000011000000100000001010000011000000100000001100";
                output = "++++++++++[>+++++++>++++++++++[>+++++++>++++++++++>+++>+<<<<-]>++.>+.+++++++..+++.>++.<<+++++++++++++++.>.+++.------.--------.>+.>.++++++++++++++++[>+++++++>++++++++++>+++>+<<<<-]>++.>+.+++++++..+++.>++.<<+++++++++++++++.>.+++.------.--------.>+.>.++++++++++++[>+++++++>++++++++++>+++>+<<<<-]>++.>+.+++++++..+++.>++.<<+++++++++++++++.>.+++.------.--------.>+.>.++>+++>+<<<<-]>++.>++++++++++[>++++++++++++++[>+++++++>++++++++++>+++>+<<<<-]>++.>+.+++++++..+++.>++.<<+++++++++++++++.>.+++.------.--------.>+.>.+++>++++++++++>+++>+<<<<-]>++.>+.+++++++..+++.>++.<<+++++++++++++++.>.+++.------.--------.>+.>.+.+++++++..+++.>++.<<+++++++++++++++.>.+++.------.--------.>+.>.";

                // Act
                result = Codecs.BrainfuckCodec.BrainfuckDecompression(input);

                //Assert
                Assert.AreEqual(output, result);
            });
        }
    }
}