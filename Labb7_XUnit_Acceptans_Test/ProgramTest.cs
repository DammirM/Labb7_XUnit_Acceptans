using Labb7_XUnit_Acceptans;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit.Sdk;

namespace Calculator_Labb_7_TestX
{
    public class ProgramTest
    {
        [Fact]
        public void Text_From_Num1_Test()
        {
            // Act
            var actual = Labb7_XUnit_Acceptans.Program.TextForNum1();
            var expected = "First number: ";

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Text_From_Num2_Test()
        {
            // Act
            var actual = Labb7_XUnit_Acceptans.Program.TextForNum2();
            var expected = "Second number: ";


            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetNumberFromUserInput_Test()
        {
            // Arrange
            var input = new StringReader("100");
            Console.SetIn(input);

            // Act
            var actual = Labb7_XUnit_Acceptans.Program.GetNumberFromUserInput();
            double expected = 100;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("100", 100)]
        [InlineData("55", 55)]
        [InlineData("88,8888", 88.8888)]
        [InlineData("-1568", -1568)]
        [InlineData("123", 123)]
        public void GetNumberFromUserInput_Theory_Test(string input, double expected)
        {
            // Arrange
            var consoleInput = new StringReader(input);
            Console.SetIn(consoleInput);

            // Act
            var actual = Labb7_XUnit_Acceptans.Program.GetNumberFromUserInput();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShowResult_Test()
        {
            // Act
            var actual = Labb7_XUnit_Acceptans.Program.ShowResult(1000);
            var expected = "\n\t1000";


            // Assert
            Assert.Equal(expected, actual);
        }
    }
}