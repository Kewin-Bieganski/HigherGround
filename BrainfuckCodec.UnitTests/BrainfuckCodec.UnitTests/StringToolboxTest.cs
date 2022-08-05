namespace BrainfuckCodec.UnitTests
{
    internal class StringToolboxTest
    {
        [Test]
        public void CharactersCount_WhenUsed_ShouldReturnStringOfCharacters()
        {
            Assert.Multiple(() =>
            {
                char inputCharacter;
                int inputCount;
                string output;
                string result;

                // Bad Path
                // Arrange
                inputCharacter = 'a';
                inputCount = -22;

                // Act
                // Assert
                Assert.That(() => Tools.StringToolbox.CharactersCount(inputCount, inputCharacter), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());

                // Normal Path
                // Arrange
                inputCharacter = '@';
                inputCount = 5;
                output = "@@@@@";

                // Act
                result = Tools.StringToolbox.CharactersCount(inputCount, inputCharacter);

                // Assert
                Assert.AreEqual(output, result);
            });
        }

        [Test]
        public void SplitBy_WhenUsed_ShouldReturnIEnumerable()
        {
            Assert.Multiple(() =>
            {
                string inputString;
                int inputSize;
                IEnumerable<string> output;
                IEnumerable<string> result;

                // Bad Path
                // Arrange
                inputString = "";
                inputSize = -41;

                // Act
                // Assert
                Assert.That(() => Tools.StringToolbox.SplitBy(inputString, inputSize), Throws.Exception.TypeOf<ArgumentException>());

                // Normal Path
                // Arrange
                inputString = "aaabbbccc";
                inputSize = 3;
                output = new List<string>{"aaa", "bbb", "ccc"};

                // Act
                result = Tools.StringToolbox.SplitBy(inputString, inputSize);

                // Assert
                Assert.AreEqual(output as IEnumerable<string>, result);
            });
        }
    }
}
